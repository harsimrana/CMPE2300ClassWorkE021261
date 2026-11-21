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
        public static int TotalCars;

        public int NumberOfDoors { get; set; }

        public Car()
        {
            TotalCars++;
            Console.WriteLine("Car CTRO is called");
        }


        // Parameterized CTOR
        public Car(string brand, int speed, int doors) 
            : base (brand, speed)    // base keyword is important here : base will call CTOR of base/parent class
        {
            Console.WriteLine("Car Parameterized CTOR is called");
            NumberOfDoors = doors;
            //Brand = brand;  // It will work why because Brand property in Vehicle class is public property
            // but if it is private then we cannot access it. Then, you need to call CTOR of base of class

            TotalCars++;

        }

        // Static CTOR 
        static Car()
        {
            Console.WriteLine("Car Static CTOR is called");
            TotalCars = 0;
        }

        public void OpenTrunk()
        {
            Console.WriteLine("Car Trunk opened");
        }

    }
}
