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

        public int Year { get; set; }

        public Car(string brand, int year= 2026)
        {
            Brand = brand;
            Year = year;
        }


        public override string ToString()
        {
            return $" {Brand} - {Year}";
        }

        public void Start() => Console.WriteLine($"{Brand} started");

        public void Stop() => Console.WriteLine($"{Brand} Stopped");
    }
}
