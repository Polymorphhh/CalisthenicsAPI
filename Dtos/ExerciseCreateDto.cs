using System.ComponentModel.DataAnnotations;

namespace CalisthenicsAPI.Dtos
{
    public class ExerciseCreateDto
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public bool Hold { get; set; }
    }
}