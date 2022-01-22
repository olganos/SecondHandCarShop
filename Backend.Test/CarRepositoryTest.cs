using Xunit;
using Moq;
using Abstraction.Repository;
using Backend.Models;
using Newtonsoft.Json;
using DAL;
using Domain;

namespace Backend.Test
{
    public class CarRepositoryTest
    {
        private readonly CarRepository _carRepository;

        public CarRepositoryTest()
        {
            _carRepository = new CarRepository();
        }

        [Fact]
        public void ShouldReturnAllCars() 
        {
            var cars = _carRepository.GetAll();

            var carsToStr = JsonConvert.SerializeObject(cars);
            var expectedToStr = JsonConvert.SerializeObject(new FakeClass().Warehouses);
            Assert.Equal(expectedToStr, carsToStr);
        }
    }
}