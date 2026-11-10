using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week06_Day01_Lambdas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Week 06: Day 01: Lambdas
             * 
             * A lambda expresion is a shortcut way of writing a function/method 
             * especially when function or method is small, and you only ned to use it once or in one place 
             * 
             * 
             * 
             */

            //Part1: Testing
            //Console.WriteLine(GetMessage());

             
            Func<string> getMessage = () =>"Welcome to 2300";
            Console.WriteLine(getMessage());

            //Part2: Testing
            WelcomeMessage();

            //Lambda Section
            Action welcomeMessage = () => Console.WriteLine("Lambda: Welcome to CMPE2300");
            welcomeMessage();

            //Part3: Testing
            Console.WriteLine("Regular Expression Part 3: " + Square(5));


            Func<int, int> getSquare = (number) => number * number;
            Console.WriteLine("Lambda Expression Part 3: " + getSquare(5));

            //Only 1 parameter?
            Func<int, int> getSquare2 = number => number * number;
            //You can leave out the parenthesis in the lambda part if only 1 parameter 
            Console.WriteLine("Lambda Expression no parenthesis on lambda: " + getSquare2(5));

            //Part4: Testing 
            Console.WriteLine("From Regular Method Part4: " + IsPositive(5));

            //With Predicates 
            //Predicates are designed for a method that accepts 1 parameter and always returns bool
            Predicate<int> isPositivePredicate = number => number > 0;
            Console.WriteLine("Predicate version: " + isPositivePredicate(5));

            //Lambda Part
            Func<int, bool> getPositiveValue = number => number > 0;
            Console.WriteLine("From lambda Part 4: " + getPositiveValue(5));

            //Part5: Testing
            Console.WriteLine("From Regular Method: " + CompareNumbers(5, 6));

            //Lambda Part
            Func<int, int, bool> getComparison = (numb1, numb2) => numb1 > numb2;
            Console.WriteLine("From Lambda Part 5: " + getComparison(5, 6));

            //Part 6: Block Lambdas: Method with multiple statements 
            Console.WriteLine("Part6: Regular Method: " + CalculateDiscount(120, 10));

            Func<double, double, double> calculateDiscount = (price, discount) =>
            {
                double amount = (price * discount) / 100;
                double finalPrice = price - amount;
                return finalPrice;
            };
            Console.WriteLine("Part6: Block Lambda: " + calculateDiscount(120, .1));

            //Part 7: 
            Console.WriteLine("Part7: Regular Method" + CalculateBalance(1500, 350, 5));

            Func<double, double, double, double> getBankBalance = (balance, withdrawal, fee) =>
            {
                double amount = balance - fee;
                double finalBalance = amount - withdrawal;
                return finalBalance;
            };
            Console.WriteLine("Part 7: Block Lambda" + getBankBalance(1500, 350, 5));

        }

        /*// Regular Method. Just to understand this, were using the student class example 
        static bool IsHighGPA(Student student)
        {
            return student.GPA >= 3.5;
        }
        //lamda expression for the same 
        student => student.GPA >= 3.5;*/

        //Part 1: Method with no parameters 
        static string GetMessage()
        {
            return "Welcome to 2300";
        }

        //Lambda expression (check in main)

        //Methid with no parameter and no Return Value
        static void WelcomeMessage()
        {
            Console.WriteLine("Welocme to CMPE2300");
        }

        //Part3: Method with one Parameter and return type 
        static int Square(int number)
        {
            return number * number;
        }
        //Part4: Method with one parameter and return a bool
        static bool IsPositive(int number)
        {
            return number > 0;
        }
        //Part5: Method with 2 or more Parameters and return 
        static bool CompareNumbers(int num1, int num2)
        {
            return num1 > num2;
        }
        //Part 6: Block Lambdas: Method with multiple statements
        static double CalculateDiscount(double price, double discount)
        {
            double amount = price * discount / 100;
            double finalPrice = price - amount;
            return finalPrice;
        }

        static double CalculateBalance(double balance, double withdrawal, double fee)
        {
            double amount = balance - fee;
            double finalBalance = amount - withdrawal;
            return finalBalance;
        }

    }
}
