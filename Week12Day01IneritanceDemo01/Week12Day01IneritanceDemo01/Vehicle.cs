using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12Day01IneritanceDemo01
{
    internal class Vehicle
    {
        public string Brand { get; set; }

        public int Speed { get; set; }

        // CTOR
        public Vehicle()
        {
            Console.WriteLine("Vehicle CTRO called");
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
