using Backend.Models;

public class FakeDto
{
    public IEnumerable<WarehouseDto> Warehouses =>
        new WarehouseDto[]
        {
                new WarehouseDto
                     {
                         Id = "1",
                         Name = "Warehouse A",
                         Location = new LocationDto
                         {
                             Lat="47.13111",
                             Lng = "-61.54801"
                         },
                         Cars = new CarsDto
                         {
                             Location = "West wing",
                             Vehicles = new VehicleDto[]
                             {
                                 new VehicleDto
                                 {
                                     Id= 1,
                                      Make= "Volkswagen",
                                      Model= "Jetta III",
                                      YearModel= 1995,
                                      Price= 12947.52,
                                      Licensed= true,
                                      DateAdded= "2018-09-18"
                                 },
                                  new VehicleDto
                                 {
                                     Id= 2,
                                      Make= "Chevrolet",
                                      Model= "Corvette",
                                      YearModel= 2004,
                                      Price= 20019.64,
                                      Licensed= true,
                                      DateAdded= "2018-01-27"
                                 }
                             }
                         }
                     },
                new WarehouseDto
                     {
                         Id = "2",
                         Name = "Warehouse B",
                         Location = new LocationDto
                         {
                             Lat="15.95386",
                             Lng = "7.06246"
                         },
                         Cars = new CarsDto
                         {
                             Location = "East wing",
                             Vehicles = new VehicleDto[]
                             {
                                 new VehicleDto
                                 {
                                     Id= 20,
                                      Make= "Maserati",
                                      Model= "Coupe",
                                      YearModel= 2005,
                                      Price= 19957.71,
                                      Licensed= false,
                                      DateAdded= "2017-11-14"
                                 },
                                  new VehicleDto
                                 {
                                     Id= 21,
                                      Make= "Isuzu",
                                      Model= "Rodeo",
                                      YearModel= 1998,
                                      Price= 6303.99,
                                      Licensed= false,
                                      DateAdded= "2017-12-03"
                                 }
                             }
                         }
                     }
        };

    public VehicleViewDto VehicleViewId_1 =>
        new VehicleViewDto
        {
            Id = 1,
            Make = "Volkswagen",
            Model = "Jetta III",
            YearModel = 1995,
            Price = 12947.52,
            Licensed = true,
            DateAdded = "2018-09-18",
            WarehouseName = "Warehouse A",
        };
}
