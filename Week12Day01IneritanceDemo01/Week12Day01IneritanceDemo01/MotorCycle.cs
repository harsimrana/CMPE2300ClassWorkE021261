using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12Day01IneritanceDemo01
{
    internal class MotorCycle: Vehicle  // Deriving Vehicle 
    {
        public bool HasSideCar { get; set; }

        public MotorCycle()
        {
            Console.WriteLine("MotorCycle CTOR is called");
        }

        public void PopWheelie()
        {
            Console.WriteLine("Motor Cycle performing a wheelie");
        }

    }
}
