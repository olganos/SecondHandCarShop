using System;

using Domain;

using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class PostgresSqlContext : DbContext
    {
        public PostgresSqlContext(DbContextOptions<PostgresSqlContext> options)
            : base(options)
        {

        }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region warehouse 1

            var warehouseId1 = 1;

            modelBuilder.Entity<Warehouse>().HasData(
                new Warehouse
                {
                    Id = warehouseId1,
                    Name = "Warehouse A",
                    Lat = "47.13111",
                    Lng = "-61.54801",
                    LocationName = "West wing",
                });

            modelBuilder.Entity<Vehicle>().HasData(
                new Vehicle
                {
                    Id = 1,
                    Make = "Volkswagen",
                    Model = "Jetta III",
                    YearModel = 1995,
                    Price = 12947.52,
                    Licensed = true,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 09, 18)),
                    WarehouseId = warehouseId1
                },
                new Vehicle
                {
                    Id = 2,
                    Make = "Chevrolet",
                    Model = "Corvette",
                    YearModel = 2004,
                    Price = 20019.64,
                    Licensed = true,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 01, 27)),
                    WarehouseId = warehouseId1
                },
                 new Vehicle
                 {
                     Id = 3,
                     Make = "Ford",
                     Model = "Expedition EL",
                     YearModel = 2008,
                     Price = 27323.42,
                     Licensed = false,
                     DateAdded = new DateTimeOffset(new DateTime(2018, 07, 03)),
                     WarehouseId = warehouseId1
                 },
                 new Vehicle
                 {
                     Id = 4,
                     Make = "Infiniti",
                     Model = "FX",
                     YearModel = 2010,
                     Price = 8541.62,
                     Licensed = true,
                     DateAdded = new DateTimeOffset(new DateTime(2018, 03, 23)),
                     WarehouseId = warehouseId1
                 },
                new Vehicle
                {
                    Id = 5,
                    Make = "GMC",
                    Model = "Safari",
                    YearModel = 1998,
                    Price = 14772.5,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 07, 04)),
                    WarehouseId = warehouseId1
                },
                 new Vehicle
                 {
                     Id = 6,
                     Make = "Plymouth",
                     Model = "Colt Vista",
                     YearModel = 1994,
                     Price = 6642.45,
                     Licensed = true,
                     DateAdded = new DateTimeOffset(new DateTime(2018, 07, 11)),
                     WarehouseId = warehouseId1
                 },
                new Vehicle
                {
                    Id = 7,
                    Make = "Cadillac",
                    Model = "Escalade ESV",
                    YearModel = 2008,
                    Price = 24925.75,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 01, 29)),
                    WarehouseId = warehouseId1
                },
                 new Vehicle
                 {
                     Id = 8,
                     Make = "Mitsubishi",
                     Model = "Pajero",
                     YearModel = 2002,
                     Price = 28619.45,
                     Licensed = false,
                     DateAdded = new DateTimeOffset(new DateTime(2018, 06, 12)),
                     WarehouseId = warehouseId1
                 },
                 new Vehicle
                 {
                     Id = 9,
                     Make = "Infiniti",
                     Model = "Q",
                     YearModel = 1995,
                     Price = 6103.4,
                     Licensed = false,
                     DateAdded = new DateTimeOffset(new DateTime(2017, 11, 13)),
                     WarehouseId = warehouseId1
                 },
                 new Vehicle
                 {
                     Id = 10,
                     Make = "Ford",
                     Model = "Mustang",
                     YearModel = 1993,
                     Price = 18992.7,
                     Licensed = false,
                     DateAdded = new DateTimeOffset(new DateTime(2018, 01, 29)),
                     WarehouseId = warehouseId1
                 },
                 new Vehicle
                 {
                     Id = 11,
                     Make = "Chevrolet",
                     Model = "G-Series 1500",
                     YearModel = 1997,
                     Price = 23362.41,
                     Licensed = false,
                     DateAdded = new DateTimeOffset(new DateTime(2018, 07, 30)),
                     WarehouseId = warehouseId1
                 },
                 new Vehicle
                 {
                     Id = 12,
                     Make = "Cadillac",
                     Model = "DeVille",
                     YearModel = 1993,
                     Price = 18371.53,
                     Licensed = false,
                     DateAdded = new DateTimeOffset(new DateTime(2018, 01, 24)),
                     WarehouseId = warehouseId1
                 },
                 new Vehicle
                 {
                     Id = 13,
                     Make = "Acura",
                     Model = "NSX",
                     YearModel = 2001,
                     Price = 23175.76,
                     Licensed = false,
                     DateAdded = new DateTimeOffset(new DateTime(2018, 03, 28)),
                     WarehouseId = warehouseId1
                 },
                new Vehicle
                {
                    Id = 14,
                    Make = "Ford",
                    Model = "Econoline E250",
                    YearModel = 1994,
                    Price = 26605.54,
                    Licensed = true,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 05, 13)),
                    WarehouseId = warehouseId1
                },
                new Vehicle
                {
                    Id = 15,
                    Make = "Lexus",
                    Model = "GX",
                    YearModel = 2005,
                    Price = 27395.26,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2017, 11, 12)),
                    WarehouseId = warehouseId1
                },
                new Vehicle
                {
                    Id = 16,
                    Make = "Dodge",
                    Model = "Ram Van 3500",
                    YearModel = 1999,
                    Price = 6244.51,
                    Licensed = true,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 09, 28)),
                    WarehouseId = warehouseId1
                },
                new Vehicle
                {
                    Id = 17,
                    Make = "Dodge",
                    Model = "Caravan",
                    YearModel = 1995,
                    Price = 16145.27,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2017, 11, 25)),
                    WarehouseId = warehouseId1
                },
                new Vehicle
                {
                    Id = 18,
                    Make = "Dodge",
                    Model = "Dynasty",
                    YearModel = 1992,
                    Price = 15103.84,
                    Licensed = true,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 08, 12)),
                    WarehouseId = warehouseId1
                },
                new Vehicle
                {
                    Id = 19,
                    Make = "Dodge",
                    Model = "Ram 1500",
                    YearModel = 2004,
                    Price = 9977.65,
                    Licensed = true,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 01, 18)),
                    WarehouseId = warehouseId1
                });

            #endregion

            #region warehouse 2

            var warehouseId2 = 2;

            modelBuilder.Entity<Warehouse>().HasData(
                new Warehouse
                {
                    Id = warehouseId2,
                    Name = "Warehouse B",
                    Lat = "15.95386",
                    Lng = "7.06246",
                    LocationName = "East wing",
                });

            modelBuilder.Entity<Vehicle>().HasData(
                new Vehicle
                {
                    Id = 20,
                    Make = "Maserati",
                    Model = "Coupe",
                    YearModel = 2005,
                    Price = 19957.71,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2017, 11, 14)),
                    WarehouseId = warehouseId2
                },
                new Vehicle
                {
                    Id = 21,
                    Make = "Isuzu",
                    Model = "Rodeo",
                    YearModel = 1998,
                    Price = 6303.99,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2017, 12, 03)),
                    WarehouseId = warehouseId2
                },
                new Vehicle
                {
                    Id = 22,
                    Make = "Infiniti",
                    Model = "I",
                    YearModel = 2002,
                    Price = 6910.16,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2017, 10, 15)),
                    WarehouseId = warehouseId2
                },
                new Vehicle
                {
                    Id = 23,
                    Make = "Nissan",
                    Model = "Altima",
                    YearModel = 1994,
                    Price = 8252.66,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 08, 12)),
                    WarehouseId = warehouseId2
                },
                new Vehicle
                {
                    Id = 24,
                    Make = "Toyota",
                    Model = "Corolla",
                    YearModel = 2009,
                    Price = 23732.11,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 02, 13)),
                    WarehouseId = warehouseId2
                },
                new Vehicle
                {
                    Id = 25,
                    Make = "Acura",
                    Model = "MDX",
                    YearModel = 2011,
                    Price = 8487.19,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 04, 18)),
                    WarehouseId = warehouseId2
                },
                new Vehicle
                {
                    Id = 26,
                    Make = "BMW",
                    Model = "7 Series",
                    YearModel = 1998,
                    Price = 29069.52,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2017, 10, 29)),
                    WarehouseId = warehouseId2
                },
                new Vehicle
                {
                    Id = 27,
                    Make = "Nissan",
                    Model = "Maxima",
                    YearModel = 2004,
                    Price = 11187.68,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 07, 16)),
                    WarehouseId = warehouseId2
                },
                new Vehicle
                {
                    Id = 28,
                    Make = "Audi",
                    Model = "A8",
                    YearModel = 1999,
                    Price = 16047.9,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2017, 12, 05)),
                    WarehouseId = warehouseId2
                },
                new Vehicle
                {
                    Id = 29,
                    Make = "Nissan",
                    Model = "Murano",
                    YearModel = 2005,
                    Price = 25859.78,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 06, 06)),
                    WarehouseId = warehouseId2
                },
                new Vehicle
                {
                    Id = 30,
                    Make = "Acura",
                    Model = "RL",
                    YearModel = 2010,
                    Price = 13232.13,
                    Licensed = true,
                    DateAdded = new DateTimeOffset(new DateTime(2017, 12, 16)),
                    WarehouseId = warehouseId2
                },
                new Vehicle
                {
                    Id = 31,
                    Make = "Mitsubishi",
                    Model = "Chariot",
                    YearModel = 1987,
                    Price = 15665.23,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 02, 21)),
                    WarehouseId = warehouseId2
                },
                new Vehicle
                {
                    Id = 32,
                    Make = "GMC",
                    Model = "3500 Club Coupe",
                    YearModel = 1992,
                    Price = 18129.37,
                    Licensed = true,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 09, 23)),
                    WarehouseId = warehouseId2
                },
                new Vehicle
                {
                    Id = 33,
                    Make = "Dodge",
                    Model = "Dakota",
                    YearModel = 2009,
                    Price = 14479.37,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2017, 12, 12)),
                    WarehouseId = warehouseId2
                },
                new Vehicle
                {
                    Id = 34,
                    Make = "Mercury",
                    Model = "Grand Marquis",
                    YearModel = 1996,
                    Price = 20614.72,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 05, 26)),
                    WarehouseId = warehouseId2
                },
                new Vehicle
                {
                    Id = 35,
                    Make = "Kia",
                    Model = "Sportage",
                    YearModel = 2001,
                    Price = 27106.47,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 03, 14)),
                    WarehouseId = warehouseId2
                },
                new Vehicle
                {
                    Id = 36,
                    Make = "Chevrolet",
                    Model = "Blazer",
                    YearModel = 1994,
                    Price = 14835.48,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2017, 11, 10)),
                    WarehouseId = warehouseId2
                },
                new Vehicle
                {
                    Id = 37,
                    Make = "Mercedes-Benz",
                    Model = "SL-Class",
                    YearModel = 1994,
                    Price = 27717.28,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 08, 17)),
                    WarehouseId = warehouseId2
                },
                new Vehicle
                {
                    Id = 38,
                    Make = "Honda",
                    Model = "Civic Si",
                    YearModel = 2003,
                    Price = 18569.86,
                    Licensed = true,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 09, 12)),
                    WarehouseId = warehouseId2
                },
                new Vehicle
                {
                    Id = 39,
                    Make = "Mercedes-Benz",
                    Model = "CL-Class",
                    YearModel = 2002,
                    Price = 23494.78,
                    Licensed = true,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 05, 24)),
                    WarehouseId = warehouseId2
                },
                new Vehicle
                {
                    Id = 40,
                    Make = "Volkswagen",
                    Model = "Jetta",
                    YearModel = 2006,
                    Price = 25469.49,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 04, 23)),
                    WarehouseId = warehouseId2
                },
                new Vehicle
                {
                    Id = 41,
                    Make = "Pontiac",
                    Model = "Grand Prix",
                    YearModel = 1975,
                    Price = 11600.74,
                    Licensed = true,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 01, 14)),
                    WarehouseId = warehouseId2
                },
                new Vehicle
                {
                    Id = 42,
                    Make = "Infiniti",
                    Model = "FX",
                    YearModel = 2012,
                    Price = 22000.62,
                    Licensed = true,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 06, 09)),
                    WarehouseId = warehouseId2
                },
                new Vehicle
                {
                    Id = 43,
                    Make = "Jaguar",
                    Model = "XK",
                    YearModel = 2006,
                    Price = 10260.79,
                    Licensed = true,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 09, 28)),
                    WarehouseId = warehouseId2
                },
                new Vehicle
                {
                    Id = 44,
                    Make = "Cadillac",
                    Model = "STS",
                    YearModel = 2007,
                    Price = 13740.2,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 02, 25)),
                    WarehouseId = warehouseId2
                },
                new Vehicle
                {
                    Id = 45,
                    Make = "Pontiac",
                    Model = "Sunfire",
                    YearModel = 1997,
                    Price = 28489.1,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2017, 12, 05)),
                    WarehouseId = warehouseId2
                },
                new Vehicle
                {
                    Id = 46,
                    Make = "Cadillac",
                    Model = "SRX",
                    YearModel = 2004,
                    Price = 26750.38,
                    Licensed = true,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 08, 07)),
                    WarehouseId = warehouseId2
                },
                new Vehicle
                {
                    Id = 47,
                    Make = "Land Rover",
                    Model = "Freelander",
                    YearModel = 2004,
                    Price = 21770.59,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 09, 01)),
                    WarehouseId = warehouseId2
                },
                new Vehicle
                {
                    Id = 48,
                    Make = "Suzuki",
                    Model = "Forenza",
                    YearModel = 2005,
                    Price = 28834.26,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 05, 09)),
                    WarehouseId = warehouseId2
                },
                new Vehicle
                {
                    Id = 49,
                    Make = "Saab",
                    Model = "9-7X",
                    YearModel = 2005,
                    Price = 25975.68,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 06, 07)),
                    WarehouseId = warehouseId2
                },
                new Vehicle
                {
                    Id = 50,
                    Make = "Ford",
                    Model = "Fusion",
                    YearModel = 2012,
                    Price = 28091.96,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 07, 15)),
                    WarehouseId = warehouseId2
                });

            #endregion

            #region warehouse 3

            var warehouseId3 = 3;

            modelBuilder.Entity<Warehouse>().HasData(
                new Warehouse
                {
                    Id = warehouseId3,
                    Name = "Warehouse C",
                    Lat = "39.12788",
                    Lng = "-2.71398",
                    LocationName = "Suid wing",
                });

            modelBuilder.Entity<Vehicle>().HasData(
                new Vehicle
                {
                    Id = 51,
                    Make = "Cadillac",
                    Model = "Escalade",
                    YearModel = 2005,
                    Price = 7429.18,
                    Licensed = true,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 09, 26)),
                    WarehouseId = warehouseId3
                },
                new Vehicle
                {
                    Id = 52,
                    Make = "Porsche",
                    Model = "Cayenne",
                    YearModel = 2011,
                    Price = 17066.31,
                    Licensed = true,
                    DateAdded = new DateTimeOffset(new DateTime(2017, 10, 19)),
                    WarehouseId = warehouseId3
                },
                new Vehicle
                {
                    Id = 53,
                    Make = "Mercedes-Benz",
                    Model = "SL-Class",
                    YearModel = 2005,
                    Price = 14066.06,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 08, 08)),
                    WarehouseId = warehouseId3
                },
                new Vehicle
                {
                    Id = 54,
                    Make = "Mitsubishi",
                    Model = "RVR",
                    YearModel = 1995,
                    Price = 22560.18,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 05, 25)),
                    WarehouseId = warehouseId3
                },
                new Vehicle
                {
                    Id = 55,
                    Make = "Volvo",
                    Model = "850",
                    YearModel = 1995,
                    Price = 25762.08,
                    Licensed = true,
                    DateAdded = new DateTimeOffset(new DateTime(2017, 10, 03)),
                    WarehouseId = warehouseId3
                },
                new Vehicle
                {
                    Id = 56,
                    Make = "Honda",
                    Model = "del Sol",
                    YearModel = 1994,
                    Price = 18840.96,
                    Licensed = true,
                    DateAdded = new DateTimeOffset(new DateTime(2017, 11, 25)),
                    WarehouseId = warehouseId3
                },
                new Vehicle
                {
                    Id = 57,
                    Make = "Infiniti",
                    Model = "Q",
                    YearModel = 1996,
                    Price = 28773.14,
                    Licensed = true,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 08, 09)),
                    WarehouseId = warehouseId3
                },
                new Vehicle
                {
                    Id = 58,
                    Make = "Mercedes-Benz",
                    Model = "500E",
                    YearModel = 1992,
                    Price = 17141.08,
                    Licensed = true,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 08, 13)),
                    WarehouseId = warehouseId3
                },
                new Vehicle
                {
                    Id = 59,
                    Make = "GMC",
                    Model = "Envoy XL",
                    YearModel = 2002,
                    Price = 18983.52,
                    Licensed = true,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 03, 14)),
                    WarehouseId = warehouseId3
                },
                new Vehicle
                {
                    Id = 60,
                    Make = "Volkswagen",
                    Model = "Touareg 2",
                    YearModel = 2008,
                    Price = 15611.22,
                    Licensed = true,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 02, 22)),
                    WarehouseId = warehouseId3
                });

            #endregion

            #region warehouse 4

            var warehouseId4 = 4;

            modelBuilder.Entity<Warehouse>().HasData(
                new Warehouse
                {
                    Id = warehouseId4,
                    Name = "Warehouse D",
                    Lat = "-70.84354",
                    Lng = "132.22345",
                    LocationName = "Suid wing",
                });

            modelBuilder.Entity<Vehicle>().HasData(
                new Vehicle
                {
                    Id = 61,
                    Make = "Saab",
                    Model = "900",
                    YearModel = 1987,
                    Price = 8771,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2017, 12, 01)),
                    WarehouseId = warehouseId4
                },
                new Vehicle
                {
                    Id = 62,
                    Make = "Mazda",
                    Model = "B-Series",
                    YearModel = 1998,
                    Price = 23407.59,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 03, 01)),
                    WarehouseId = warehouseId4
                },
                new Vehicle
                {
                    Id = 63,
                    Make = "GMC",
                    Model = "Sierra 3500",
                    YearModel = 2012,
                    Price = 5869.23,
                    Licensed = true,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 04, 27)),
                    WarehouseId = warehouseId4
                },
                new Vehicle
                {
                    Id = 64,
                    Make = "Chevrolet",
                    Model = "Corvette",
                    YearModel = 1964,
                    Price = 16630.67,
                    Licensed = true,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 05, 31)),
                    WarehouseId = warehouseId4
                },
                new Vehicle
                {
                    Id = 65,
                    Make = "Toyota",
                    Model = "Tacoma",
                    YearModel = 1997,
                    Price = 11597.18,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 03, 30)),
                    WarehouseId = warehouseId4
                },
                new Vehicle
                {
                    Id = 66,
                    Make = "GMC",
                    Model = "Sonoma",
                    YearModel = 2004,
                    Price = 18248.21,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 03, 09)),
                    WarehouseId = warehouseId4
                },
                new Vehicle
                {
                    Id = 67,
                    Make = "Bugatti",
                    Model = "Veyron",
                    YearModel = 2009,
                    Price = 8051.64,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 01, 10)),
                    WarehouseId = warehouseId4
                },
                new Vehicle
                {
                    Id = 68,
                    Make = "Dodge",
                    Model = "Ram 1500 Club",
                    YearModel = 1996,
                    Price = 14008.3,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 05, 01)),
                    WarehouseId = warehouseId4
                },
                new Vehicle
                {
                    Id = 69,
                    Make = "Land Rover",
                    Model = "Discovery Series II",
                    YearModel = 2001,
                    Price = 18620.19,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 03, 03)),
                    WarehouseId = warehouseId4
                },
                new Vehicle
                {
                    Id = 70,
                    Make = "Volvo",
                    Model = "960",
                    YearModel = 1993,
                    Price = 7316.93,
                    Licensed = true,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 02, 15)),
                    WarehouseId = warehouseId4
                },
                new Vehicle
                {
                    Id = 71,
                    Make = "Chrysler",
                    Model = "LHS",
                    YearModel = 2001,
                    Price = 29444.71,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2017, 10, 25)),
                    WarehouseId = warehouseId4
                },
                new Vehicle
                {
                    Id = 72,
                    Make = "Porsche",
                    Model = "944",
                    YearModel = 1984,
                    Price = 7396.95,
                    Licensed = true,
                    DateAdded = new DateTimeOffset(new DateTime(2017, 10, 26)),
                    WarehouseId = warehouseId4
                },
                new Vehicle
                {
                    Id = 73,
                    Make = "Subaru",
                    Model = "Legacy",
                    YearModel = 2010,
                    Price = 24491.8,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2017, 12, 26)),
                    WarehouseId = warehouseId4
                },
                new Vehicle
                {
                    Id = 74,
                    Make = "Volvo",
                    Model = "XC90",
                    YearModel = 2003,
                    Price = 29009.65,
                    Licensed = true,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 04, 24)),
                    WarehouseId = warehouseId4
                },
                new Vehicle
                {
                    Id = 75,
                    Make = "Buick",
                    Model = "Skyhawk",
                    YearModel = 1985,
                    Price = 10567.27,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 03, 21)),
                    WarehouseId = warehouseId4
                },
                new Vehicle
                {
                    Id = 76,
                    Make = "GMC",
                    Model = "Envoy XUV",
                    YearModel = 2004,
                    Price = 20997.71,
                    Licensed = true,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 03, 27)),
                    WarehouseId = warehouseId4
                },
                new Vehicle
                {
                    Id = 77,
                    Make = "Volvo",
                    Model = "S60",
                    YearModel = 2009,
                    Price = 28614.95,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 07, 25)),
                    WarehouseId = warehouseId4
                },
                new Vehicle
                {
                    Id = 78,
                    Make = "Pontiac",
                    Model = "Montana",
                    YearModel = 2000,
                    Price = 11221.14,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 01, 04)),
                    WarehouseId = warehouseId4
                },
                new Vehicle
                {
                    Id = 79,
                    Make = "Lexus",
                    Model = "RX",
                    YearModel = 2002,
                    Price = 23194.01,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 05, 02)),
                    WarehouseId = warehouseId4
                },
                new Vehicle
                {
                    Id = 80,
                    Make = "Lexus",
                    Model = "RX",
                    YearModel = 2000,
                    Price = 17805.45,
                    Licensed = false,
                    DateAdded = new DateTimeOffset(new DateTime(2018, 09, 11)),
                    WarehouseId = warehouseId4
                });

            #endregion
        }
    }
}
