using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CalisthenicsAPI.Dtos
{
    public class SetCreateDto
    {
        [Required]
        public int Repetition { get; set; }
        
        [Required]
        public int RestTime { get; set; }

        [Required]
        public int TrainingId { get; set; }
    }
}