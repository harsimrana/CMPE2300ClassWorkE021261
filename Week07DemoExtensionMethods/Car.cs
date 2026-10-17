using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week07DemoExtensionMethods
{
    internal class Car
    {
        public string Brand { get; set; }

        public Car(string brand)
        {
            Brand = brand;
        }

        public void Start() => Console.WriteLine($"{Brand} started");

        public void Stop() => Console.WriteLine($"{Brand} Stopped");
    }
}
