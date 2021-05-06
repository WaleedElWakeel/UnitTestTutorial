using System;
using System.Collections.Generic;
using CarsApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarsAppTests
{
    [TestClass]
    public class CarTests
    {
        public TestContext TestContext { get; set; }

        #region Additional test attributes

        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            testContext.WriteLine("Class init");
        }

        [ClassCleanup()]
        public static void MyClassCleanup()
        {
            
        }

        [TestInitialize()]
        public void MyTestInitialize() 
        {
            TestContext.WriteLine("Test Init");
        }

        [TestCleanup()]
        public void MyTestCleanup() 
        {
            TestContext.WriteLine("Test Clean Up");
        }

        #endregion

        #region Assert
        [Owner("Waleed")]
        [Priority(1)]
        [TestCategory("Assert")]
        [TestMethod]
        public void TimeToCoverProvidedDistance_Distance100Velocity25_Returns4EqualExpected()
        {
            // Arrange
            var car = new Car(CarType.Audi, 25, DrivingMode.Forward);


            // Act
            var actual = car.TimeToCoverProvidedDistance(100);
            double expected = 4;


            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestCategory("Assert")]
        [TestMethod]
        public void TimeToCoverProvidedDistance_Distance100Velocity25_Returns4NotEqualExpected()
        {
            // Arrange
            var car = new Car(CarType.Audi, 25, DrivingMode.Forward);


            // Act
            var actual = car.TimeToCoverProvidedDistance(100);
            double expected = 5;


            //Assert
            Assert.AreNotEqual(actual, expected);
        }

        [Ignore]
        [TestMethod]
        public void CarCTOR_2DifferentInstances_NotSameObjects()
        {
            var car = new Car();
            var car2 = new Car();


            //Assert.AreSame(car, car2);
            Assert.AreNotSame(car, car2);
            
            // testing singlteon
            // Are same check reference, Are Equal can compare type and values, try

        }

        [TestMethod]
        public void CarEquality_SameState_EqualButNotSame()
        {
            var car1 = new Car(CarType.Audi, 50,DrivingMode.Forward);
            var car2 = new Car(CarType.Audi, 50,DrivingMode.Forward);

            Assert.AreEqual(car1, car2);
            //Assert.AreSame(car1, car2);
        }

        [TestMethod]
        public void GetMyCar_InstanceExist_IsInstanceOfCar()
        {
            var car = new Car();

            var actual = car.GetMyCar();

            Assert.IsInstanceOfType(actual, typeof(Car));

        }

        [TestMethod]
        public void GetMyCar_InstanceExist_IsNotNull()
        {
            var car = new Car();

            var actual = car.GetMyCar();

            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void Accelerate_ToyotaInitialVelocity50_IncreaseTo60()
        {
            var car = new Car(CarType.Toyota, 50, DrivingMode.Forward);

            car.Accelerate();
            double actual = car.Velocity;
            double expected = 60;

            Assert.IsTrue(actual == expected);
        }
        #endregion


        #region StringAssert
        [TestMethod]
        public void GetDirection_Forward_PrintsForward()
        {
            var car = new Car(CarType.Audi, 70, DrivingMode.Forward);

            var actual = car.GetDirection();
            var expected = "Forwa";

            //StringAssert.Contains(actual, expected);
            StringAssert.StartsWith(actual, expected);
        }
        #endregion


        #region CollectionAssert

        [TestMethod]
        public void CarStoreCars_ProvidingSameCarsToTwoStores_AreEqual()
        {
            Car c1 = new Car(CarType.Audi, 10, DrivingMode.Forward);
            Car c2 = new Car(CarType.BMW, 20, DrivingMode.Reverse);
            Car c3 = new Car(CarType.Audi, 10, DrivingMode.Forward);
            Car c4 = new Car(CarType.BMW, 20, DrivingMode.Reverse);

            CarStore carStore1 = new CarStore();
            CarStore carStore2 = new CarStore();
            carStore1.Cars.Add(c1);
            carStore1.Cars.Add(c2);
            carStore2.Cars.Add(c3);
            carStore2.Cars.Add(c4);

            
            CollectionAssert.AreEqual(carStore2.Cars, carStore1.Cars);
            //CollectionAssert.AreEqual(carStore2.Cars, carStore1.Cars);
        }

        [TestMethod]
        public void CarStoreCars_ProvidingSameCarsToTwoStores_AreEquivalent()
        {
            Car c1 = new Car(CarType.Audi, 10, DrivingMode.Forward);
            Car c2 = new Car(CarType.BMW, 20, DrivingMode.Reverse);
            Car c3 = new Car(CarType.Audi, 10, DrivingMode.Forward);
            Car c4 = new Car(CarType.BMW, 20, DrivingMode.Reverse);

            CarStore carStore1 = new CarStore();
            CarStore carStore2 = new CarStore();
            carStore1.Cars.Add(c1);
            carStore1.Cars.Add(c2);
            carStore2.Cars.Add(c3);
            carStore2.Cars.Add(c4);


            //CollectionAssert.AreEquivalent(carStore2.Cars, carStore1.Cars);
            CollectionAssert.AreNotEquivalent(carStore2.Cars, carStore1.Cars);
        }

        #endregion


        #region Exception

        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void GetDirection_NoDirectionProvided_NullExcpetion()
        {
            var car = new Car();

            car.GetDirection();
        }
        #endregion
    }
}
