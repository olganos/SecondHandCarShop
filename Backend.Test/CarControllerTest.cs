using Xunit;
using Moq;
using Abstraction.Repository;
using Backend.Controllers;
using Backend.Models;
using Newtonsoft.Json;

namespace Backend.Test
{
    public class CarControllerTest
    {

        private readonly Mock<ICarRepository> _carRepositoryMock;
        private readonly CarController _carController;

        public CarControllerTest()
        {
            _carRepositoryMock = new Mock<ICarRepository>();
            _carController = new CarController(_carRepositoryMock.Object);
        }

        [Fact]
        public void ShouldReturnAllCars() 
        {
            var response = _carController.Get();

            var responseToStr = JsonConvert.SerializeObject(response);
            var expectedToStr = JsonConvert.SerializeObject(new Class1().Warehouses);
            Assert.Equal(responseToStr, expectedToStr);
        }
    }
}