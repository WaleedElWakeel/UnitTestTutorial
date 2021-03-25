using CarAPI.Entities;
using CarAPI.Repositories_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarAPI.Services_BLL
{
    public class CarService : ICarService
    {
        private ICarRepository CarsRepository { get; set; }
        public CarService(ICarRepository carsRepository)
        {
            CarsRepository = carsRepository;
        }

        public List<Car> GetAll()
        {
            return CarsRepository.GetAllCars();
        }

        public Car GetCarById(int id)
        {
            var car = CarsRepository.GetCarById(id);
            return car;
        }
        public double TimeToCoveredProvidedDistance(Car car,double distance)
        {
            return distance / car.Velocity;
        }

        public void Accelerate(Car car)
        {
            switch (car.Type)
            {
                case CarType.BMW:
                    car.Velocity += 10;
                    break;
                case CarType.Audi:
                    car.Velocity += 15;
                    break;
                default:
                    throw new ArgumentNullException();
            }
        }
        public void Brake(Car car)
        {
            switch (car.Type)
            {
                case CarType.BMW:
                    car.Velocity -= 10;
                    break;
                case CarType.Audi:
                    car.Velocity -= 15;
                    break;
                default:
                    throw new ArgumentNullException();
            }
        }

        public void Stop(Car car)
        {
            car.Velocity = 0;
        }

        public void AddCar(Car car)
        {
            CarsRepository.AddCar(car);
        } 
    }
}