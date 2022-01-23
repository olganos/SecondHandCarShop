using Xunit;
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

        [Fact]
        public void ShouldReturnOneCar()
        {
            var car = _carRepository.GetOne(1);

            var carToStr = JsonConvert.SerializeObject(car);
            var expectedToStr = JsonConvert.SerializeObject(new FakeClass().getVehicleById(1));
            Assert.Equal(expectedToStr, carToStr);
        }

        [Fact]
        public void ShouldReturnNUllIfCarNotExists()
        {
            var car = _carRepository.GetOne(10);
            Assert.Null(car);
        }
    }
}