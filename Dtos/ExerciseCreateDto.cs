using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CalisthenicsAPI.Dtos
{
    public class ExerciseCreateDto
    {
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [MaxLength(250)]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [Required]
        [JsonPropertyName("hold")]
        public bool Hold { get; set; }
    }
}