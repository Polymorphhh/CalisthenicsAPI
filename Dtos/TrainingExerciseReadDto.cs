namespace CalisthenicsAPI.Dtos
{
    public class TrainingExerciseReadDto
    {
        public int Id { get; set; }
        
        public ExerciseReadDto RefExercise { get; set; }
           
        public int Duration { get; set; }

        public int Repetition { get; set; }
    }
}