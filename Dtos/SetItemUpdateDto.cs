using System.ComponentModel.DataAnnotations;

namespace CalisthenicsAPI.Dtos
{
    public class SetItemUpdateDto
    {           
        public int Duration { get; set; }

        public int Repetition { get; set; }

        [Required]
        public int SetId { get; set; }
        
        [Required]
        public int ExerciseId { get; set; }
    }
}