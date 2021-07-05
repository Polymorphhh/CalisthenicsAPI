using System.ComponentModel.DataAnnotations;

namespace CalisthenicsAPI.Models
{
    public class Exercise
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }

        [Required]
        public bool Hold { get; set; }
    }
}