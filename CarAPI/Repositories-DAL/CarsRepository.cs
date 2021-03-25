using CarAPI.Entities;
using CarAPI.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarAPI.Repositories_DAL
{
    public class CarsRepository : ICarRepository
    {
        public InMemoryContext Context { get; set; }
        public CarsRepository(InMemoryContext context)
        {
            Context = context;
        }

        public List<Car> GetAllCars()
        {
            return Context.Cars;
        }
        
        public Car GetCarById(int id)
        {
            return Context.Cars.FirstOrDefault(c => c.Id == id);
        }

        public void AddCar(Car car)
        {
            Context.Cars.Add(car);
        }
    }
}