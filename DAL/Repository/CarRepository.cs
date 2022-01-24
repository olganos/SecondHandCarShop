using Abstraction.Repository;
using Microsoft.EntityFrameworkCore;

using Domain;

namespace DAL
{
    public class CarRepository : ICarRepository
    {
        protected readonly PostgresSqlContext PostgresSqlContext;

        public CarRepository(PostgresSqlContext postgresSqlContext) =>
            PostgresSqlContext = postgresSqlContext;

        public IEnumerable<Warehouse> GetAll() =>
            PostgresSqlContext.Set<Warehouse>()
            .Include(i => i.Vehicles)
            .AsEnumerable();

        public Vehicle? GetOne(int id)
        {
            return PostgresSqlContext.Set<Vehicle>()
                .Where(x => x.Id == id)
                .Include(i => i.Warehouse)
                .FirstOrDefault();
        }
    }
}
