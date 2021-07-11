using System.ComponentModel.DataAnnotations;

namespace CalisthenicsAPI.Dtos
{
    public class SetItemUpdateDto
    {    
        [Required]
        public int Id { get; set; }
        
        public int Duration { get; set; }

        public int Repetition { get; set; }
        
        public int ExerciseId { get; set; }
    }
}