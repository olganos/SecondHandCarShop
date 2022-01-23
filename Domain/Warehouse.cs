namespace Domain
{
    public class Warehouse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Location Location { get; set; }

        public string LocationName { get; set; }

        public IEnumerable<Vehicle> Vehicles { get; set; }
    }
}
