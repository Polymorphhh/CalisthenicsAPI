using System.ComponentModel.DataAnnotations;

namespace CalisthenicsAPI.Dtos
{
    public class TrainingExerciseUpdateDto
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        public ExerciseUpdateDto RefExercise { get; set; }
           
        public int Duration { get; set; }

        public int Repetition { get; set; }
    }
}