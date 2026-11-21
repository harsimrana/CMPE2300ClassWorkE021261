using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12Day01IneritanceDemo01
{
    internal class Vehicle
    {
        public static int TotalVehicles;

        public string Brand { get; set; }

        public int Speed { get; set; }

        // CTOR
        public Vehicle()
        {
            Console.WriteLine("Vehicle CTOR is called");
            TotalVehicles++;
        }

        // Parameterized CTOR
        public Vehicle(string brand, int speed)
        {
            TotalVehicles++;
            Console.WriteLine("Vehicle Parameterized CTOR is called");
            Brand = brand;
            Speed = speed;
        }


        //Static CTOR
        static Vehicle()
        {
            TotalVehicles = 0;
            Console.WriteLine("Vehicle Static CTOR  is called");
        }


        public void Start()
        {
            Console.WriteLine("Vehicle started");

        }

        public void Stop()
        {
            Console.WriteLine("Vehicle stopped");
        }

    }
}
