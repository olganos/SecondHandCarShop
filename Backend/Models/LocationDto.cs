using System.Text.Json.Serialization;

namespace Backend.Models
{
    public class LocationDto
    {
        public string Lat { get; set; }

        [JsonPropertyName("long")]
        public string Lng { get; set; }
    }
}
