using System.Text.Json.Serialization;

namespace CalisthenicsAPI.Dtos
{
    public class ExerciseReadDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("hold")]
        public bool Hold { get; set; }
    }
}