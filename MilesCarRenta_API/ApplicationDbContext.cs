using Microsoft.EntityFrameworkCore;
using MilesCarRenta_API.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MilesCarRenta_API
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car()
                {
                    Id = 1,
                    Plate_number = "PTH15E",
                    Model = "2018",
                    Brand = "Chevrolet",
                    Vehicule_type = "Camioneta",
                    Engine_capacity = "1600cc",
                    Status = 'D',
                    Location_id = 1,
                    Created_at = DateTime.Now,
                    Updated_at = DateTime.Now,

                },
                new Car()
                {
                    Id = 2,
                    Plate_number = "KNQ32",
                    Model = "2022",
                    Brand = "Chevrolet",
                    Vehicule_type = "Automovil",
                    Engine_capacity = "1200cc",
                    Status = 'D',
                    Location_id=1,
                    Created_at = DateTime.Now,
                    Updated_at = DateTime.Now,
                },
                new Car()
                {
                    Id = 3,
                    Plate_number = "ATR21",
                    Model = "2009",
                    Brand = "Mazda",
                    Vehicule_type = "Automovil",
                    Engine_capacity = "1400cc",
                    Status = 'O',
                    Location_id=2,
                    Created_at = DateTime.Now,
                    Updated_at = DateTime.Now,
                },
                new Car()
                {
                    Id = 4,
                    Plate_number = "KNP98",
                    Model = "2017",
                    Brand = "Nissan",
                    Vehicule_type = "Campero",
                    Engine_capacity = "1600cc",
                    Status = 'O',
                    Location_id=3,
                    Created_at = DateTime.Now,
                    Updated_at = DateTime.Now,
                },
                new Car()
                {
                    Id = 5,
                    Plate_number = "KNP98",
                    Model = "2017",
                    Brand = "Nissan",
                    Vehicule_type = "Campero",
                    Engine_capacity = "1600cc",
                    Status = 'O',
                    Location_id=4,
                    Created_at = DateTime.Now,
                    Updated_at = DateTime.Now,
                },
                 new Car()
                 {
                     Id = 6,
                     Plate_number = "ARS45",
                     Model = "2007",
                     Brand = "Wolsvagen",
                     Vehicule_type = "Sub",
                     Engine_capacity = "1600cc",
                     Status = 'D',
                     Location_id=3,
                     Created_at = DateTime.Now,
                     Updated_at = DateTime.Now,
                 }
            );

            modelBuilder.Entity<Location>().HasData(
                
                new Location()
                {
                    Id = 1,
                    Name= "Parque Central",
                    Description = "Parque deportivo",
                    Latitude = 10.4881f,
                    Longitude= -66.8796f
                },
                 new Location()
                 {
                     Id = 2,
                     Name = "Torre Central",
                     Description = "Telecomunicaciones",
                     Latitude = 48.8584f,
                     Longitude = 2.2945f
                 },
                  new Location()
                  {
                      Id = 3,
                      Name = "Plaza de Bolivar",
                      Description = "Plaza principal",
                      Latitude = 55.7539f,
                      Longitude = 37.6208f
                  },
                  new Location()
                  {
                      Id = 4,
                      Name = "Salitre Magico",
                      Description = "Parque de Recreacion",
                      Latitude = -13.1631f,
                      Longitude = -72.5450f
                  },
                  new Location()
                  {
                      Id = 5,
                      Name = "Movistar Arena",
                      Description = "Estadio",
                      Latitude = 29.9792f,
                      Longitude = 31.1344f
                  }
                );
            modelBuilder.Entity<ReturnOptions>().HasData(
                
                new ReturnOptions()
                {
                    Id= 1,
                    Description = "La devolucion se realizará en horario de la tarde",
                    Location_id = 2,
                    Address = " CALLE 26 #35-180 ",
                    Name_receiving_mamanger = "Luisa Quevedo"
                    
                },
                new ReturnOptions()
                {
                    Id = 2,
                    Description = "La devolucion se realizará en horario de la mañana en el local directamente",
                    Location_id = 4,
                    Address = " CALLE 1N #185-96 ",
                    Name_receiving_mamanger = "Maria Rojas"

                },
                new ReturnOptions()
                {
                    Id = 3,
                    Description = "La devolucion se realizará en horario de la mañana",
                    Location_id = 5,
                    Address = " CALLE 24N #259-123 ",
                    Name_receiving_mamanger = "Camila Duque"

                },
                new ReturnOptions()
                {
                    Id = 4,
                    Description = "La devolucion se realizará en horario laboral de 8 a 12 y de 2 a 6 en el parqueadero disponible",
                    Location_id = 1,
                    Address = " Carrera 15 #54-43 Bastilla Parqueadero ",
                    Name_receiving_mamanger = "Lorena Arias"

                },
                new ReturnOptions()
                {
                    Id = 5,
                    Description = "La devolucion se realizará en horario de la tarde en el local directamente",
                    Location_id = 3,
                    Address = " 80 con calle 10 #89-74",
                    Name_receiving_mamanger = "Eliza Flores"

                }

                );



        }

    }
}
