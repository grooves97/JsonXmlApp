using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO;

namespace CarsApp
{
    [DataContract]
    public class Car
    {
        [DataMember]
        public string Brand { get; set; }
        [DataMember]
        public string Model { get; set; }
        [DataMember]
        public double TankCapacity { get; set; }
        [DataMember]
        public string Body { get; set; }
        [DataMember]
        public string Coutry { get; set; }
        [DataMember]
        public int ManufacYear { get; set; }

        public void Show()
        {
            Console.WriteLine($"Марка: {Brand}");
            Console.WriteLine($"Модель: {Model}");
            Console.WriteLine($"Кузов: {Body}");
            Console.WriteLine($"Страна: {Coutry}");
            Console.WriteLine($"Объем: {TankCapacity}");
            Console.WriteLine($"Год выпуска: {ManufacYear}\n");
        }
    }
}
