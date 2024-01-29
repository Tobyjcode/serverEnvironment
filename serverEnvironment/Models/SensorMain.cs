using System.ComponentModel.DataAnnotations;

namespace serverEnvironment.Models
{
    public class SensorMain
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public  string Location { get; set; }
        [Required]
        public int GroupId { get; set; }

    }
}
