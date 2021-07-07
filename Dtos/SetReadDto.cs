using System.Collections.Generic;

namespace CalisthenicsAPI.Dtos
{
    public class SetReadDto
    {
        public int Repetition { get; set; }
        
        public int RestTime { get; set; }

        public ICollection<TrainingExerciseReadDto> TrainingExercises { get; set; }
    }
}