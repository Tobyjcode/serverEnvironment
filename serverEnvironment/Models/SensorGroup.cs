using System.ComponentModel.DataAnnotations;

namespace serverEnvironment.Models
{
    public class SensorGroup
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int SensorGroupTypeId { get; set; }
    }
}
