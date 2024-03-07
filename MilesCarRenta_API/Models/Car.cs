using System.ComponentModel.DataAnnotations;

namespace MilesCarRenta_API.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Plate_number { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Vehicule_type { get; set; }
        [Required]
        public string Engine_capacity { get; set; }
        [Required]
        public char Status { get; set; }
        [Required]
        public int Location_id { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
    }
}
