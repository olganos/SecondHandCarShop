using Microsoft.AspNetCore.Mvc;
using AutoMapper;

using Abstraction.Repository;
using Backend.Models;

namespace Backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository _carRepository;
        //private readonly IMapper _mapper;

        public CarController(ICarRepository carRepository/*, IMapper mapper*/)
        {
            _carRepository = carRepository;
            //_mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<Warehouse> Get()
        {
            return new Class1().Warehouses;
        }
    }
}
