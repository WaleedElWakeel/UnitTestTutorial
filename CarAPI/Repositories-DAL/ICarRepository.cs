using CarAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAPI.Repositories_DAL
{
    public interface ICarRepository
    {
        
        List<Car> GetAllCars();
        Car GetCarById(int id);
        void AddCar(Car car);
    }
}
