using System.ComponentModel.DataAnnotations;

namespace serverEnvironment.Models
{
    public class Sensor
    {
        [Key]
        public int Id { get; set; }
        public int TypeId { get; set; }
        public int GroupId { get; set; }
        public decimal Value { get; set; }
        public DateTime Created { get; set; }
    }
}
