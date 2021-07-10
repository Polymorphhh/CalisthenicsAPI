using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CalisthenicsAPI.Dtos
{
    public class SetUpdateDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int Repetition { get; set; }
        
        [Required]
        public int RestTime { get; set; }
        
        public ICollection<TrainingExerciseUpdateDto> TrainingExercises { get; set; }
    }
}