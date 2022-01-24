namespace Domain
{
    public class Warehouse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Lat { get; set; }

        public string Lng { get; set; }

        public string LocationName { get; set; }

        public IEnumerable<Vehicle> Vehicles { get; set; }
    }
}
