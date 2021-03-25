using CarAPI.Entities;
using CarAPI.Repositories_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAPITests
{
    public class FakeCarsRepo : ICarRepository
    {
        public List<Car> Cars;

        public FakeCarsRepo()
        {
            Cars = new List<Car>()
            {
                new Car(1,CarType.Audi, 30),
                new Car(2, CarType.Audi, 40),
                new Car(3, CarType.BMW, 50)
            };
        }
        public List<Car> GetAllCars()
        {
            return Cars;
        }

        public Car GetCarById(int id)
        {
            return Cars.FirstOrDefault(c => c.Id == id);
        }

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }
    }
}
