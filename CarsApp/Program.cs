using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(CarType.Audi, 10, DrivingMode.Forward);
        }
    }
}
