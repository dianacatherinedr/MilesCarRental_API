using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MilesCarRenta_API.DTO_s;
using MilesCarRenta_API.Models;
using System.Runtime.CompilerServices;

namespace MilesCarRenta_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ILogger<CarController> _logger;
        private readonly ApplicationDbContext _context;

        public CarController(ILogger<CarController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;

        }

        [HttpGet("location-pickup")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        /**
         * Metodo que me permite encontrar vehiculos disponibles segun el lugar de recogida
         */
        public async Task<ActionResult<CarDto>> GetCarAvaibleLocationPickup(int locationId)
        {
            if(locationId == 0)
            {
                _logger.LogError("Error al buscar locación:" + locationId);
               return BadRequest();
            }

            // Buscar los carros disponibles basados en el ID de la ubicación
            var availableCars = await _context.Cars
                .Where(c => c.Location_id == locationId && c.Status == 'D')
                .Select(c => new CarDto
                {
                    Id = c.Id,
                    Plate_number = c.Plate_number,
                    Model = c.Model,   
                    Brand = c.Brand,
                    Vehicule_type = c.Vehicule_type,
                    Engine_capacity = c.Engine_capacity
                })
                .ToListAsync();

            if (availableCars.Any())
            {
                return Ok(availableCars);
            }
            else
            {
                _logger.LogError("No se encontro ningun vehiculo asociado a esa locación:" + locationId);
                return NotFound();
            }
        }

        [HttpGet("available-for-zone")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        /**
         * Metodo para calcular disponibilidad de carros segun mercado, en este caso se solicita un parametro adicional, que es la busqueda de la cantidad de kilometros que 
         * que se desea buscar a la redonde, sea 1,2 100 km a la redonda, como los datos son pocos se recomienda usar algunos, los encuentra en el README.
        */
        public async Task<ActionResult<IEnumerable<CarDto>>> GetAvailableCarsForZone(int locationId, float userLatitude, float userLongitude, double searchRadiusKm)
        {
            // Obtener la ubicación de la locación proporcionada
            var location = await _context.Locations.FirstOrDefaultAsync(l => l.Id == locationId);
            if (location == null)
            {
                return NotFound();
            }

            // Calcular la distancia entre la ubicación del usuario y la ubicación de la locación
            double distanceToLocation = CalculateDistance(location.Latitude, location.Longitude, userLatitude, userLongitude);

            // Filtrar los carros disponibles en la locación dentro del radio específico
            var availableCars = await _context.Cars
                .Where(c => c.Location_id == locationId && c.Status == 'D')
                .ToListAsync();

            // Filtrar los carros dentro del radio específico
            availableCars = availableCars.Where(c => CalculateDistance(location.Latitude, location.Longitude, userLatitude, userLongitude) <= searchRadiusKm).ToList();

            if (!availableCars.Any())
            {
                return NotFound();
            }

            return Ok(availableCars.Select(c => new CarDto
            {
                Id = c.Id,
                Plate_number = c.Plate_number,
                Model = c.Model,
                Brand = c.Brand,
                Vehicule_type = c.Vehicule_type,
                Engine_capacity = c.Engine_capacity
            }));
        }

        // Método para calcular la distancia entre dos puntos geográficos utilizando la fórmula de Haversine
        private double CalculateDistance(float lat1, float lon1, float lat2, float lon2)
        {
            const double earthRadiusKm = 6371;

            var dLat = (lat2 - lat1) * Math.PI / 180;
            var dLon = (lon2 - lon1) * Math.PI / 180;

            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                    Math.Cos(lat1 * Math.PI / 180) * Math.Cos(lat2 * Math.PI / 180) *
                    Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            var distance = earthRadiusKm * c;
            return distance;
        }
    }
}
