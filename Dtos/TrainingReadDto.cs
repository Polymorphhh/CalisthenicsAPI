using System.Collections.Generic;

namespace CalisthenicsAPI.Dtos
{
    public class TrainingReadDto
    {
        public int Name { get; set; }

        public string Description { get; set; }

        public ICollection<SetReadDto> Sets { get; set; }
    }
}