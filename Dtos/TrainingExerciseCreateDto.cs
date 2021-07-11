using System.ComponentModel.DataAnnotations;

namespace CalisthenicsAPI.Dtos
{
    public class TrainingExerciseCreateDto
    {       
        [Required]
        public ExerciseReadDto RefExercise { get; set; }
           
        public int Duration { get; set; }

        public int Repetition { get; set; }
    }
}