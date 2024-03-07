using System.ComponentModel.DataAnnotations;

namespace MilesCarRenta_API.DTO_s
{
    public class CarDto
    {
  
        public int Id { get; set; }
        public string Plate_number { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Vehicule_type { get; set; }
        public string Engine_capacity { get; set; }
        public char Status { get; set; }
    }
}
