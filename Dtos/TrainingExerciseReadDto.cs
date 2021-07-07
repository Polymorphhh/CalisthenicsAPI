using System.Collections.Generic;

namespace CalisthenicsAPI.Dtos
{
    public class TrainingExerciseReadDto
    {
        public ExerciseReadDto RefExercise { get; set; }
           
        public int Duration { get; set; }

        public int Repetition { get; set; }
    }
}