using System.ComponentModel.DataAnnotations;

namespace CalisthenicsAPI.Models
{
    public class SetItem
    {
        [Key]
        public int Id { get; set; }
          
        public int Duration { get; set; }

        public int Repetition { get; set; }

        [Required]
        public int SetId { get; set; }
        
        [Required]
        public int ExerciseId { get; set; }

        public Exercise Exercise { get; set; }
    }
}