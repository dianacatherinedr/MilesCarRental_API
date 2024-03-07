namespace MilesCarRenta_API.DTO_s
{
    using NetTopologySuite.Geometries;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class LotacionDto
    {
     
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public Point Geolocation { get; set; }
    }
}
