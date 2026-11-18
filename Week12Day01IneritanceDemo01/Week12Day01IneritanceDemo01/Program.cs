using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12Day01IneritanceDemo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inheritance is an Importance principle of OOP
            // allows one class to derive/acquire the properties and methods of another 
            // class

            // Vehicle class you can derive Car or Motorcycle or Truck
            // All these vehicles have something common
            // Common features: Brand, model, year, Speed, Start() Stop()
            // Specific features
            //      Car         : number of doors, number of seats
            //      Motorcycle  : has sidecar  Method wheelie()
            //      Truck       : truck bed or cargo Capacity, Load Cargo() 

            // IS - A relation - Car IS A  vehicle

            // We have defined a vehicle class [check Vehicle.cs file]. Now we will derive a class
            // from vehicle - CAR [check Car.cs]


            // Create some objects 

            Car myCar = new Car();

            myCar.Brand = "Toyota";
            myCar.Speed = 120;
            myCar.NumberOfDoors = 4;

            Console.WriteLine($" Car Information : {myCar.Brand} | {myCar.Speed} | {myCar.NumberOfDoors} ");

            myCar.Start();
            myCar.OpenTrunk();
            myCar.Stop();

            // Add another class MotorCycle [check MotorCycle.cs]

            MotorCycle bike = new MotorCycle();

            bike.Brand = "Yahama";
            bike.Speed = 90;

            bike.Start();
            bike.PopWheelie();
            bike.Stop();

            // Both objects can call Start() Stop() methods inherited from Vehicle class

            // but 
            //myCar.PopWheelie();  // NOT Possible
            //bike.OpenTrunk(); // NOT Possible

            // WHY ??

            // Because PopWheelie belongs only to MotorCycle class 
            // and OpenTruck() belongs only to Car class

            // HOW DO CTOR WORK WITH INHERITANCE
            // 

            // It will call vehicle CTOR first why?
            // because when Car object is created, C# must initilize the base class portiong of the 
            // of the object before running the derived class CTOR body.

        }
    }
}
