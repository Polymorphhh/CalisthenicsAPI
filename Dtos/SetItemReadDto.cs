namespace CalisthenicsAPI.Dtos
{
    public class SetItemReadDto
    {
        public int Id { get; set; }
                  
        public int Duration { get; set; }

        public int Repetition { get; set; }

        public int SetId { get; set; }
        
        public int ExerciseId { get; set; }

        public ExerciseReadDto Exercise { get; set; }
    }
}