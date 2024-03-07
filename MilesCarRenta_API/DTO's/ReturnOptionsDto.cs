using System.ComponentModel.DataAnnotations;

namespace MilesCarRenta_API.DTO_s
{
    public class ReturnOptionsDto
    {
      
        public int Id { get; set; }
        public string Description { get; set; }
        public int Location_id { get; set; }
        public string Address { get; set; }
        public string Name_receiving_mamanger { get; set; }
    }
}
