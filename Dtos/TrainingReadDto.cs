using System.Collections.Generic;

namespace CalisthenicsAPI.Dtos
{
    public class TrainingReadDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<SetReadDto> Sets { get; set; }
    }
}