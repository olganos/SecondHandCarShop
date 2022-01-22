using System.Text.Json.Serialization;

namespace Backend.Models
{
    public class VehicleDto
    {
        [JsonPropertyName("_id")]
        public int Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        [JsonPropertyName("year_model")]
        public int YearModel { get; set; }

        public double Price { get; set; }

        public bool Licensed { get; set; }

        [JsonPropertyName("date_added")]
        public string DateAdded { get; set; }
    }
}
