using System.ComponentModel.DataAnnotations;

namespace serverEnvironment.Models
{
    public class Sensor
    {
        [Key]
        public int Id { get; set; }
        public int SensorId { get; set; }
        public decimal SensorValue { get; set; }
        public DateTime Created { get; set; }
        public int GroupId { get; set; }
    }
}
