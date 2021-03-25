using CarAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAPI.Services_BLL
{
    public interface ICarService
    {
        void Accelerate(Car car);
        void AddCar(Car car);
        void Brake(Car car);
        List<Car> GetAll();
        Car GetCarById(int id);
        void Stop(Car car);
        double TimeToCoveredProvidedDistance(Car car, double distance);
    }
}
