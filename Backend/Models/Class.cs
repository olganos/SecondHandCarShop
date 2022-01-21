using System.Text.Json.Serialization;

namespace Backend.Models
{
    public class Warehouse
    {
        [JsonPropertyName("_id")]
        public string Id { get; set; }

        public string Name { get; set; }

        public Location Location { get; set; }

        public Cars Cars { get; set; }
    }

    public class Location
    {
        public string Lat { get; set; }

        [JsonPropertyName("long")]
        public string Lng { get; set; }
    }

    public class Cars
    {
        public string Location { get; set; }

        public Vehicle[] Vehicles { get; set; }
    }

    public class Vehicle
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
