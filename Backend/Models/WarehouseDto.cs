using System.Text.Json.Serialization;

namespace Backend.Models
{
    public class WarehouseDto
    {
        [JsonPropertyName("_id")]
        public string Id { get; set; }

        public string Name { get; set; }

        public LocationDto Location { get; set; }

        public CarsDto Cars { get; set; }
    }
}
