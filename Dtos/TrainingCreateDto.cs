using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CalisthenicsAPI.Dtos
{
    public class TrainingCreateDto
    {
        [Required]
        public string Name { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }

        public ICollection<SetCreateDto> Sets { get; set; }
    }
}