namespace Backend.Models
{
    public class CarsDto
    {
        public string Location { get; set; }

        public VehicleDto[] Vehicles { get; set; }
    }
}
