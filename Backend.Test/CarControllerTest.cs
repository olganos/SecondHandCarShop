using Xunit;
using Moq;
using Newtonsoft.Json;
using AutoMapper;
using Abstraction.Repository;
using Backend.Controllers;

namespace Backend.Test
{
    public class CarControllerTest
    {

        private readonly Mock<ICarRepository> _carRepositoryMock;
        private readonly IMapper _mapper;
        private readonly CarController _carController;

        public CarControllerTest()
        {
            _carRepositoryMock = new Mock<ICarRepository>();

            var mappingConfig = new MapperConfiguration(mc => mc.AddProfile(new AutoMapperConfig()));
            _mapper = mappingConfig.CreateMapper();

            _carController = new CarController(_carRepositoryMock.Object, _mapper);
        }

        [Fact]
        public void ShouldReturnAllCars()
        {
            _carRepositoryMock.Setup(x => x.GetAll()).Returns(new FakeDomain().Warehouses);

            var response = _carController.Get();

            var responseToStr = JsonConvert.SerializeObject(response);
            var expectedToStr = JsonConvert.SerializeObject(new FakeDto().Warehouses);
            Assert.Equal(expectedToStr, responseToStr);
        }

        [Fact]
        public void ShouldReturnOneCar()
        {
            var id = 1;
            _carRepositoryMock.Setup(x => x.GetOne(id)).Returns(new FakeDomain().getVehicleById(id));
            var response = _carController.Get(id);

            var responseToStr = JsonConvert.SerializeObject(response.Value);
            var expectedToStr = JsonConvert.SerializeObject(new FakeDto().VehicleViewId_1);
            Assert.Equal(expectedToStr, responseToStr);
        }
    }
}