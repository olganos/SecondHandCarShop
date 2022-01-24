using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DAL.Migrations
{
    public partial class createDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Lat = table.Column<string>(type: "text", nullable: false),
                    Lng = table.Column<string>(type: "text", nullable: false),
                    LocationName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Make = table.Column<string>(type: "text", nullable: false),
                    Model = table.Column<string>(type: "text", nullable: false),
                    YearModel = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    Licensed = table.Column<bool>(type: "boolean", nullable: false),
                    DateAdded = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    WarehouseId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "Id", "Lat", "Lng", "LocationName", "Name" },
                values: new object[,]
                {
                    { 1, "47.13111", "-61.54801", "West wing", "Warehouse A" },
                    { 2, "15.95386", "7.06246", "East wing", "Warehouse B" },
                    { 3, "39.12788", "-2.71398", "Suid wing", "Warehouse C" },
                    { 4, "-70.84354", "132.22345", "Suid wing", "Warehouse D" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "DateAdded", "Licensed", "Make", "Model", "Price", "WarehouseId", "YearModel" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2018, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, "Volkswagen", "Jetta III", 12947.52, 1, 1995 },
                    { 2, new DateTimeOffset(new DateTime(2018, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, "Chevrolet", "Corvette", 20019.639999999999, 1, 2004 },
                    { 3, new DateTimeOffset(new DateTime(2018, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Ford", "Expedition EL", 27323.419999999998, 1, 2008 },
                    { 4, new DateTimeOffset(new DateTime(2018, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, "Infiniti", "FX", 8541.6200000000008, 1, 2010 },
                    { 5, new DateTimeOffset(new DateTime(2018, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "GMC", "Safari", 14772.5, 1, 1998 },
                    { 6, new DateTimeOffset(new DateTime(2018, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, "Plymouth", "Colt Vista", 6642.4499999999998, 1, 1994 },
                    { 7, new DateTimeOffset(new DateTime(2018, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Cadillac", "Escalade ESV", 24925.75, 1, 2008 },
                    { 8, new DateTimeOffset(new DateTime(2018, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Mitsubishi", "Pajero", 28619.450000000001, 1, 2002 },
                    { 9, new DateTimeOffset(new DateTime(2017, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Infiniti", "Q", 6103.3999999999996, 1, 1995 },
                    { 10, new DateTimeOffset(new DateTime(2018, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Ford", "Mustang", 18992.700000000001, 1, 1993 },
                    { 11, new DateTimeOffset(new DateTime(2018, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Chevrolet", "G-Series 1500", 23362.41, 1, 1997 },
                    { 12, new DateTimeOffset(new DateTime(2018, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Cadillac", "DeVille", 18371.529999999999, 1, 1993 },
                    { 13, new DateTimeOffset(new DateTime(2018, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Acura", "NSX", 23175.759999999998, 1, 2001 },
                    { 14, new DateTimeOffset(new DateTime(2018, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, "Ford", "Econoline E250", 26605.540000000001, 1, 1994 },
                    { 15, new DateTimeOffset(new DateTime(2017, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Lexus", "GX", 27395.259999999998, 1, 2005 },
                    { 16, new DateTimeOffset(new DateTime(2018, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, "Dodge", "Ram Van 3500", 6244.5100000000002, 1, 1999 },
                    { 17, new DateTimeOffset(new DateTime(2017, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Dodge", "Caravan", 16145.27, 1, 1995 },
                    { 18, new DateTimeOffset(new DateTime(2018, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, "Dodge", "Dynasty", 15103.84, 1, 1992 },
                    { 19, new DateTimeOffset(new DateTime(2018, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, "Dodge", "Ram 1500", 9977.6499999999996, 1, 2004 },
                    { 20, new DateTimeOffset(new DateTime(2017, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Maserati", "Coupe", 19957.709999999999, 2, 2005 },
                    { 21, new DateTimeOffset(new DateTime(2017, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Isuzu", "Rodeo", 6303.9899999999998, 2, 1998 },
                    { 22, new DateTimeOffset(new DateTime(2017, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Infiniti", "I", 6910.1599999999999, 2, 2002 },
                    { 23, new DateTimeOffset(new DateTime(2018, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Nissan", "Altima", 8252.6599999999999, 2, 1994 },
                    { 24, new DateTimeOffset(new DateTime(2018, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Toyota", "Corolla", 23732.110000000001, 2, 2009 },
                    { 25, new DateTimeOffset(new DateTime(2018, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Acura", "MDX", 8487.1900000000005, 2, 2011 },
                    { 26, new DateTimeOffset(new DateTime(2017, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "BMW", "7 Series", 29069.52, 2, 1998 },
                    { 27, new DateTimeOffset(new DateTime(2018, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Nissan", "Maxima", 11187.68, 2, 2004 },
                    { 28, new DateTimeOffset(new DateTime(2017, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Audi", "A8", 16047.9, 2, 1999 },
                    { 29, new DateTimeOffset(new DateTime(2018, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Nissan", "Murano", 25859.779999999999, 2, 2005 },
                    { 30, new DateTimeOffset(new DateTime(2017, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, "Acura", "RL", 13232.129999999999, 2, 2010 },
                    { 31, new DateTimeOffset(new DateTime(2018, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Mitsubishi", "Chariot", 15665.23, 2, 1987 },
                    { 32, new DateTimeOffset(new DateTime(2018, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, "GMC", "3500 Club Coupe", 18129.369999999999, 2, 1992 },
                    { 33, new DateTimeOffset(new DateTime(2017, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Dodge", "Dakota", 14479.370000000001, 2, 2009 },
                    { 34, new DateTimeOffset(new DateTime(2018, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Mercury", "Grand Marquis", 20614.720000000001, 2, 1996 },
                    { 35, new DateTimeOffset(new DateTime(2018, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Kia", "Sportage", 27106.470000000001, 2, 2001 },
                    { 36, new DateTimeOffset(new DateTime(2017, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Chevrolet", "Blazer", 14835.48, 2, 1994 },
                    { 37, new DateTimeOffset(new DateTime(2018, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Mercedes-Benz", "SL-Class", 27717.279999999999, 2, 1994 },
                    { 38, new DateTimeOffset(new DateTime(2018, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, "Honda", "Civic Si", 18569.860000000001, 2, 2003 },
                    { 39, new DateTimeOffset(new DateTime(2018, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, "Mercedes-Benz", "CL-Class", 23494.779999999999, 2, 2002 },
                    { 40, new DateTimeOffset(new DateTime(2018, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Volkswagen", "Jetta", 25469.490000000002, 2, 2006 },
                    { 41, new DateTimeOffset(new DateTime(2018, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, "Pontiac", "Grand Prix", 11600.74, 2, 1975 },
                    { 42, new DateTimeOffset(new DateTime(2018, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, "Infiniti", "FX", 22000.619999999999, 2, 2012 },
                    { 43, new DateTimeOffset(new DateTime(2018, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, "Jaguar", "XK", 10260.790000000001, 2, 2006 },
                    { 44, new DateTimeOffset(new DateTime(2018, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Cadillac", "STS", 13740.200000000001, 2, 2007 },
                    { 45, new DateTimeOffset(new DateTime(2017, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Pontiac", "Sunfire", 28489.099999999999, 2, 1997 },
                    { 46, new DateTimeOffset(new DateTime(2018, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, "Cadillac", "SRX", 26750.380000000001, 2, 2004 },
                    { 47, new DateTimeOffset(new DateTime(2018, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Land Rover", "Freelander", 21770.59, 2, 2004 },
                    { 48, new DateTimeOffset(new DateTime(2018, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Suzuki", "Forenza", 28834.259999999998, 2, 2005 },
                    { 49, new DateTimeOffset(new DateTime(2018, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Saab", "9-7X", 25975.68, 2, 2005 },
                    { 50, new DateTimeOffset(new DateTime(2018, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Ford", "Fusion", 28091.959999999999, 2, 2012 },
                    { 51, new DateTimeOffset(new DateTime(2018, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, "Cadillac", "Escalade", 7429.1800000000003, 3, 2005 },
                    { 52, new DateTimeOffset(new DateTime(2017, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, "Porsche", "Cayenne", 17066.310000000001, 3, 2011 },
                    { 53, new DateTimeOffset(new DateTime(2018, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Mercedes-Benz", "SL-Class", 14066.059999999999, 3, 2005 },
                    { 54, new DateTimeOffset(new DateTime(2018, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Mitsubishi", "RVR", 22560.18, 3, 1995 },
                    { 55, new DateTimeOffset(new DateTime(2017, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, "Volvo", "850", 25762.080000000002, 3, 1995 },
                    { 56, new DateTimeOffset(new DateTime(2017, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, "Honda", "del Sol", 18840.959999999999, 3, 1994 },
                    { 57, new DateTimeOffset(new DateTime(2018, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, "Infiniti", "Q", 28773.139999999999, 3, 1996 },
                    { 58, new DateTimeOffset(new DateTime(2018, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, "Mercedes-Benz", "500E", 17141.080000000002, 3, 1992 },
                    { 59, new DateTimeOffset(new DateTime(2018, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, "GMC", "Envoy XL", 18983.52, 3, 2002 },
                    { 60, new DateTimeOffset(new DateTime(2018, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, "Volkswagen", "Touareg 2", 15611.219999999999, 3, 2008 },
                    { 61, new DateTimeOffset(new DateTime(2017, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Saab", "900", 8771.0, 4, 1987 },
                    { 62, new DateTimeOffset(new DateTime(2018, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Mazda", "B-Series", 23407.59, 4, 1998 },
                    { 63, new DateTimeOffset(new DateTime(2018, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, "GMC", "Sierra 3500", 5869.2299999999996, 4, 2012 },
                    { 64, new DateTimeOffset(new DateTime(2018, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, "Chevrolet", "Corvette", 16630.669999999998, 4, 1964 },
                    { 65, new DateTimeOffset(new DateTime(2018, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Toyota", "Tacoma", 11597.18, 4, 1997 },
                    { 66, new DateTimeOffset(new DateTime(2018, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "GMC", "Sonoma", 18248.209999999999, 4, 2004 },
                    { 67, new DateTimeOffset(new DateTime(2018, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Bugatti", "Veyron", 8051.6400000000003, 4, 2009 },
                    { 68, new DateTimeOffset(new DateTime(2018, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Dodge", "Ram 1500 Club", 14008.299999999999, 4, 1996 },
                    { 69, new DateTimeOffset(new DateTime(2018, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Land Rover", "Discovery Series II", 18620.189999999999, 4, 2001 },
                    { 70, new DateTimeOffset(new DateTime(2018, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, "Volvo", "960", 7316.9300000000003, 4, 1993 },
                    { 71, new DateTimeOffset(new DateTime(2017, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Chrysler", "LHS", 29444.709999999999, 4, 2001 },
                    { 72, new DateTimeOffset(new DateTime(2017, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, "Porsche", "944", 7396.9499999999998, 4, 1984 },
                    { 73, new DateTimeOffset(new DateTime(2017, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Subaru", "Legacy", 24491.799999999999, 4, 2010 },
                    { 74, new DateTimeOffset(new DateTime(2018, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, "Volvo", "XC90", 29009.650000000001, 4, 2003 },
                    { 75, new DateTimeOffset(new DateTime(2018, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Buick", "Skyhawk", 10567.27, 4, 1985 },
                    { 76, new DateTimeOffset(new DateTime(2018, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, "GMC", "Envoy XUV", 20997.709999999999, 4, 2004 },
                    { 77, new DateTimeOffset(new DateTime(2018, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Volvo", "S60", 28614.950000000001, 4, 2009 },
                    { 78, new DateTimeOffset(new DateTime(2018, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Pontiac", "Montana", 11221.139999999999, 4, 2000 },
                    { 79, new DateTimeOffset(new DateTime(2018, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Lexus", "RX", 23194.009999999998, 4, 2002 },
                    { 80, new DateTimeOffset(new DateTime(2018, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, "Lexus", "RX", 17805.450000000001, 4, 2000 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_WarehouseId",
                table: "Vehicles",
                column: "WarehouseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Warehouses");
        }
    }
}
