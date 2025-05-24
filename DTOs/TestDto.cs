using System.Text.Json.Serialization;

namespace Api.DTOs
{
    public class TestDto
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Description { get; set; }
    }
}
