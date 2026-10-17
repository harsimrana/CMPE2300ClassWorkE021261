using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week07DemoExtensionMethods
{


    // RULE #01 : Extension methos live in a static, non-generic class
    internal static class CarExtensions
    {

        // RULE #02: The method should be a static method
        // RULE #03: 'this Car car' (<T>) should be the FIRST parameter
        // RULE #04: Additional paramenters (destination) follow that first one 
        // 
        //                       'this' is creating a magic
        public static void NavigateTo(this Car car, string destination)
        { 
            // this Car car tells C# that this method extends the Car Type
            // car refers to the object on which the method is called
            Console.WriteLine($" {car.Brand} navigating to  {destination}");
        }

    }
}
