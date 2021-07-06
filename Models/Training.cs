using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CalisthenicsAPI.Models
{
    public class Training
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Name { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }   

        [Required]
        public ICollection<Set> Sets { get; set; }
    }
}