using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week06Day01_Lambda_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Week 06: Day 01: Lambda
             * 
             * A Lambda Expression is simply a short way of writing 
             * a function/method, especially when function/method is small and you only need to use it in one place
             * 
             * 
             */

            //Part 1:  Testing

            Console.WriteLine( GetMessage() );

            Func<string> getMessage = () => "Welcome to 2300";

            Console.WriteLine(getMessage());

            // Not That way
            //Console.WriteLine(() => "Welcome to 2300");


            // Part 2: Testing
            WelcomeMessage();

            // Lambda part 
            Action welcomeMessage = () => Console.WriteLine("Lambda: Welcome to CMPE 2300");

            welcomeMessage();

            // Part 3: Testing 

            Console.WriteLine("Regular Method: " + Square(5));

            Func<int, int> findSqaure = (number) => number * number;

            // It will work with () [paratheses] as well if there is only one parameter
            
            // Func<int, int> findSqaure = number => number * number;

            Console.WriteLine("Lambda Expression: " + findSqaure(5));


            //Part 4: Testing
            Console.WriteLine(IsPositive(5));

            //  last one is always return data type
            Func<int, bool> isPositive = number => number > 0;

            // Can we write Part 4 with Predicate delegate type
            // is specially designed for a method that
            // accepts one value
            // return bool

            Predicate<int> isPositiveV1 = number => number > 0;

            Console.WriteLine("Lambda Part : "+ isPositiveV1(5));

            Console.WriteLine(isPositive(5));

            //Part 5: Testing 

            Func < int, int, bool> compareNumber = (numb1, numb2) => numb1 > numb2;

            Console.WriteLine("Lambda Part "+compareNumber(4, 5));

            // Part 6: Testing

            // Lambda expression for Block Lambda 

            Func<double, double, double> calculateDiscount = (price, discount) =>
            {
                double amount = (price * discount)/100;
                double finalPrice = price - amount;

                return finalPrice;
            };

            Console.WriteLine(calculateDiscount(120, 10));
        }

        // Just to understand it, we are using Student Class example 
        // Regular method 
        /*static bool IsHighGPA(Student student)
        {
            return student.GPA >= 3.5;
        }
        */
        // Lambda Expression for the same
        //student => student.GPA >= 3.5;

        //Part 1: Method with no parameters

        static string GetMessage()
        {
            return "Welcome to 2300";
        }

        // Lambda Expression Check in Main Method

        //Part 2: Method with No parameter and no Return value
        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to CMPE 2300");
        }

        // Part 3: Method with one Parameter and return type
        static int Square(int number)
        {
            return number * number;
        }

        // Part 4: Method with one parameter and return bool

        static bool IsPositive(int number)
        {
            return number > 0;
        }

        // Write Lambda


        //Part 5: Method with 2 or more Parameters and return 
        static bool CompareNumber(int numb1, int numb2)
        {
            return numb1 > numb2;
        }

        // Lambda Expression

        // Part 6: Block Lambda: Method with multiple statements

        static double CalculateDiscount(double price, double discount)
        {
            double amount = (price * discount) /100;
            double finalPrice = price - amount;

            return finalPrice;
        }

        

        
        
    }
}
