using System;
using System.Collections.Generic;
using CarAPI.Entities;
using CarAPI.Repositories_DAL;
using CarAPI.Services_BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CarsAPITests
{
    [TestClass]
    public class CarServiceTests
    {
        #region Tightly coupled Example
        [TestMethod]
        public void TimeToCoveredProvidedDistance_Distance100Velocity50_Returns()
        {
            var carService = new CarService(new CarsRepository(new InMemoryContext()));
            var car = new Car(4, CarType.BMW, 50);

            var actualTime = carService.TimeToCoveredProvidedDistance(car, 100);
            var expected = 2; 

            Assert.AreEqual(expected, actualTime);
        }

        [TestMethod]
        public void Accelerate_AddNewCarWithVelocity50AndTypeBMW_Returns60()
        {
            var carService = new CarService(new CarsRepository(new InMemoryContext()));
            var car = new Car(4, CarType.BMW, 50);

            carService.AddCar(car);
            var car2 = carService.GetCarById(4);
            carService.Accelerate(car2);
            double expectedVelocity = 60;

            Assert.AreEqual(expectedVelocity, car2.Velocity);
        }
        #endregion

        #region Fake Repo
        [TestMethod]
        public void Accelerate_AddNewCarWithFakeRepoWithVelocity50AndTypeBMW_Returns60()
        {
            var carService = new CarService(new FakeCarsRepo());
            var car = new Car(4, CarType.BMW, 50);

            carService.AddCar(car);
            var car2 = carService.GetCarById(4);
            carService.Accelerate(car2);
            double expectedVelocity = 60;

            Assert.AreEqual(expectedVelocity, car2.Velocity);
        }
        #endregion

        #region MOQ
        [TestMethod]
        public void Accelerate_AddNewCarWithMoQWithVelocity50AndTypeBMW_Returns60()
        {
            //Arrange
            Mock<ICarRepository> mockRepo = new Mock<ICarRepository>();
            var carService = new CarService(mockRepo.Object);
            var car = new Car(4, CarType.BMW, 50);
            mockRepo.Setup(r => r.GetCarById(4)).Returns(car);

            //Act
            carService.AddCar(car);
            var car2 = carService.GetCarById(4);
            carService.Accelerate(car2);
            double expectedVelocity = 60;

            //Assert
            mockRepo.Verify(r => r.AddCar(car));
            Assert.AreEqual(expectedVelocity, car2.Velocity);
        }
            #endregion
        }
}
