using System.ComponentModel.DataAnnotations;

namespace CalisthenicsAPI.Dtos
{
    public class ExerciseUpdateDto
    {
        [Required]
        public string Name { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }

        [Required]
        public bool Hold { get; set; }
    }
}