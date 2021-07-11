using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CalisthenicsAPI.Dtos
{
    public class TrainingUpdateDto
    {
        [Required]
        public string Name { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }

        public ICollection<SetUpdateDto> Sets { get; set; }
    }
}