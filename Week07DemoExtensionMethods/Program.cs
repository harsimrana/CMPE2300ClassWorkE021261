using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week07DemoExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Week 07: Extension Methods

            // Car example to understand the concept
            // Extension methods: it will allow us to add functionality to an existing class or type
            // without modifying its original source code.
            // C# 3.0 with .NET Fraework 3.5 in 2007  Not sure about the year ???


            // Let's use our Car class
            
            Car car = new Car("Totyota");
            // Car has Start and Stop methods, so we can call those
            car.Start();

            car.Stop();
            // Car has no built in functionality for Navigation

            // can we call NavigateTo() directly on car object
            //CarExtensions.NavigateTo(car, "Edmonton Airport");

            // I want to access NavigateTo using my car instanc/object Possible ??
            // YES with Extension Methods

            //LINE 37
            car.NavigateTo("Edmonton Airport");
            // it will also work
            // internally compiler will converts line number 37 into an ordinary static method call like the following
            CarExtensions.NavigateTo(car, "Edmonton Airport");

            // Extension mehtods do not actually insert new method into your original class. They provide a conveient 
            // syntax for calling static methods.


            // Now let's work with any built in data type


            double value = Math.PI;

            Console.WriteLine($"PI, round 2: {value.ToFixed2()}");
            Console.WriteLine($"PI, round 3: {value.ToFixed(3)}");


            // Exercise solution to add a method to count number of words in any string

            string sentence = "I  am  learning  C#  OOPS\nconcepts";

            int numberOfWords = sentence.CountWords();

            Console.WriteLine($"Number of words {numberOfWords}");

            //NEXT Important piece
            List<int> list = new List<int>() { 10, 20, 30 };
            
            int[] arrayofNumbers = { 40, 50, 60 };

            DisplayNumbers(list);
            // Not possible with current method signature
            //DisplayNumbers(arrayofNumbers);
            
            //Possible with generic extensions 
            DisplayNumbers(arrayofNumbers);

            //IEnumerable<T> only promises that we can enumerate (foreach )


            IEnumerable<int> readAsSequence = list;
            //readAsSequence.Add(45); // DOES NOT COMPILE: Add is not IEnumerable <T>

            List<int> listA = new List<int>() { 1, 2, 2, 3, 4, 5 ,7,7 };
            List<int> listB = new List<int>() { 3, 4, 5, 6 };

            // CONCAT = A followed by B, includeing duplicates

            IEnumerable<int> readAsList = listA.Concat(listB);

            readAsList.PrintItems("Concat");

            // DISTINCT = unique values of one sequence

            listA.Distinct().PrintItems("Distict on list A");

            listA.Concat(listB).Distinct().PrintItems("Distict after Concat");

            // Union = All unique values from either sequence

            listA.Union(listB).PrintItems("Union");

            // INTERSECT = value found in BOTH

            listA.Intersect(listB).PrintItems("A Intersect B ");

            // EXCEPT = values in A but not in B

            listA.Except(listB).PrintItems(" A Except B ");  // 1,2, 7

            listB.Except(listA).PrintItems("B Except A ");  // 6

        }


        //private static void DisplayNumbers(List<int> numbers)
        //{ 
        //    foreach(int n in numbers)
        //    {
        //        Console.WriteLine(n);
        //    }
        //}
        private static void DisplayNumbers(IEnumerable<int> numbers)
        {
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
