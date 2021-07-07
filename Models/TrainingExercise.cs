using System.ComponentModel.DataAnnotations;

namespace CalisthenicsAPI.Models
{
    public class TrainingExercise
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Exercise RefExercise { get; set; }
           
        public int Duration { get; set; }

        public int Repetition { get; set; }
    }
}