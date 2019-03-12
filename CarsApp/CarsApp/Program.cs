using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO;
using Newtonsoft.Json;

namespace CarsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            var vehiсle = new List<Car>();

            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Car>));

            using (FileStream fs = new FileStream("./Cars.json",FileMode.OpenOrCreate))
            {
                //var file = File.OpenRead("Cars.json");
                List<Car> newVehiсle = (List<Car>)jsonFormatter.ReadObject(fs);
                newVehiсle.ToString();
                //string json = JsonConvert.DeserializeObject();

                foreach (var c in newVehiсle)
                {
                    car.Show();
                }
            }


            Console.ReadLine();
        }
    }
}
