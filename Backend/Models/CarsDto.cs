namespace Backend.Models
{
    public class CarsDto
    {
        public string Location { get; set; }

        public IEnumerable<VehicleDto> Vehicles { get; set; }
    }
}
