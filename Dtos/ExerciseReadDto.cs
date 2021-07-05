using System.ComponentModel.DataAnnotations;

namespace CalisthenicsAPI.Dtos
{
    public class ExerciseReadDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool Hold { get; set; }
    }
}