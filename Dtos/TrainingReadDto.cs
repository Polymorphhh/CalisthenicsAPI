using System.Collections.Generic;

namespace CalisthenicsAPI.Dtos
{
    public class TrainingReadDto
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public IEnumerable<SetReadDto> Sets { get; set; }
    }
}