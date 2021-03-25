using CarAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarAPI.Repositories_DAL
{
    public class CarsRepoOracle : ICarRepository
    {
        public InMemoryContext InMemoryContext { get; }
        public CarsRepoOracle(InMemoryContext inMemoryContext)
        {
            InMemoryContext = inMemoryContext;
        }


        public void AddCar(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllCars()
        {
            throw new NotImplementedException();
        }

        public Car GetCarById(int id)
        {
            throw new NotImplementedException();
        }
    }
}