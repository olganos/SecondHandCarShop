namespace Backend.Models
{

    public class Rootobject
    {
        public Warehouse[] Property1 { get; set; }
    }

    public class Warehouse
    {
        public string _id { get; set; }
        public string name { get; set; }
        public Location location { get; set; }
        public Cars cars { get; set; }
    }

    public class Location
    {
        public string lat { get; set; }
        public string _long { get; set; }
    }

    public class Cars
    {
        public string location { get; set; }
        public Vehicle[] vehicles { get; set; }
    }

    public class Vehicle
    {
        public int _id { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public int year_model { get; set; }
        public float price { get; set; }
        public bool licensed { get; set; }
        public string date_added { get; set; }
    }

}
