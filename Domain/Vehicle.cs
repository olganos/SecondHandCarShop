namespace Domain
{
    public class Vehicle
    {
        public int Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int YearModel { get; set; }

        public double Price { get; set; }

        public bool Licensed { get; set; }

        public DateTimeOffset DateAdded { get; set; }

        public int WarehouseId { get; set; }

        public Warehouse Warehouse { get; set; }
    }
}