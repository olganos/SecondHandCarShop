using Abstraction.Repository;

using Domain;

namespace DAL
{
    public class CarRepository : ICarRepository
    {
        public IEnumerable<Warehouse> GetAll()
        {
            return new FakeClass().Warehouses;
        }

        public Vehicle? GetOne(int id)
        {
            return new FakeClass().getVehicleById(id);
        }
    }
}
