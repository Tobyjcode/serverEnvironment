using System.ComponentModel.DataAnnotations;

namespace serverEnvironment.Models
{
    public class SensorType
    {
        [Key]
        public int Id {  get; set; }
        public int SensorTypeId {  get; set; }
    }
}
