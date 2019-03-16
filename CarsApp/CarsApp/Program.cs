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
            Car car = new Car()
            {
                Brand = "LandRover",
                Model = "RangeRover",
                TankCapacity = 5.5,
                Body = "SUV",
                Coutry = "Great Britain",
                ManufacYear = 2019
            };

        }
    }
}
