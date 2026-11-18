using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12Day01IneritanceDemo01
{

    // FOR INHERITANCE : use colon to derive a class

    internal class Car : Vehicle  // NOTICE this line : tells C# that Car inherits from Vehicle
    {
        public int NumberOfDoors { get; set; }


        public Car()
        {
            Console.WriteLine("Car CTRO is called");
        }

        public void OpenTrunk()
        {
            Console.WriteLine("Car Trunk opened");
        }

    }
}
