using System.ComponentModel.DataAnnotations;

namespace MilesCarRenta_API.Models
{
    public class ReturnOptions
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(300)]
        public string Description { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Name_receiving_mamanger{ get; set; }
        [Required]
        public int Location_id { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
    }
}
