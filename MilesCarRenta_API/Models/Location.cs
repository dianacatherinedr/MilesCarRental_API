namespace MilesCarRenta_API.Models

{
    using NetTopologySuite.Geometries;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Location
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public float Latitude { get; set; }
        [Required]
        public float Longitude { get; set; }
        [NotMapped]
        public Point Geolocation { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }

    }
}
