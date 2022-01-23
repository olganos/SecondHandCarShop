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
        private readonly IMapper _mapper;

        public CarController(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<WarehouseDto> Get()
        {
            return _mapper.Map<IEnumerable<WarehouseDto>>(_carRepository.GetAll());
        }

        [HttpGet("{id}")]
        public WarehouseDto Get(int id)
        {
            return _mapper.Map<WarehouseDto>(_carRepository.GetOne(id));
            // todo: throw notfound
        }
    }
}
