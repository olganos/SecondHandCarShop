using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Warehouse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Location Location { get; set; }

        public string LocationName { get; set; }

        public Vehicle[] Vehicles { get; set; }
    }

    public class Location
    {
        public string Lat { get; set; }

        public string Lng { get; set; }
    }
}
