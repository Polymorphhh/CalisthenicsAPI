using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CalisthenicsAPI.Models
{
    public class Set
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Repetition { get; set; }
        
        [Required]
        public int RestTime { get; set; }

        [Required]
        public ICollection<TrainingExercise> TrainingExercises { get; set; }
    }
}