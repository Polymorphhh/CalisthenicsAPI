using System.ComponentModel.DataAnnotations;

namespace CalisthenicsAPI.Dtos
{
    public class SetItemCreateDto
    {                 
        public int Duration { get; set; }

        public int Repetition { get; set; }

        public int SetId { get; set; }

        public int ExerciseId { get; set; }
    }
}