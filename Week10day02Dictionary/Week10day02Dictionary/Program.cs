using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10day02Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Dictionaries in C# 
             * Coffee Shop Menu Example 
             * Taking variables  to store information about price of different items
             * A dictionary will store data in the form of key-value pair
             * 
             * You look up a word (key)
             * you will get its meaning (value)
             * 
             * in our coffee shop example 
             * You look up for the item name ( key)
             * You will get its price (value)
             * 
             * Coffee   $3.50
             * Tea      $2.49
             * Sandwich $6.35
             * 
             * Important rule to keep in mind, Your key must be unique, but values can be repeated
             * 
             * 
             */

            // Creating an empty dictionary 
            Dictionary<string, double> menu = new Dictionary<string, double>();

            // Dictionary is the collection type
            // string specifies the type of key such as coffee
            // double specifies the value type such as 3.50
            // menu is variable  name


            // Add items using Add() 
            // General syntax: dictionary.Add(key, value)

            menu.Add("Coffee", 3.50);
            menu.Add("Tea", 2.49);
            menu.Add("Sandwich", 6.99);
            menu.Add("Cookie", 1.75);

            // Can we add another item with the same price?
            // YES, two keys can have same value 
            menu.Add("Hot Chocoolate", 3.50);

            // What will happen if I am going to add something like that

            // menu.Add("Coffee", 4.50);  // Not possible to add duplicate key


            // How can retrieve any value using its key

            Console.WriteLine( menu["Coffee"] );

            //Try catch 
            // ContainsKey()  : bool result
            Console.WriteLine(menu.ContainsKey("Coffee"));
            Console.WriteLine(menu.ContainsKey("Pizza"));

            if (menu.ContainsKey("Coffee"))
            {
                Console.WriteLine($" Coffee  : {menu["Coffee"]}");
            }

            // ContainsValue()
            Console.WriteLine(menu.ContainsValue(3.5));

            // Another Safe way to seach for keys

            // TryGetValue()
            // It will return true if the item exists, otherwise false
            // It stores the retireved price in the price variable through the out paramenter
            if (menu.TryGetValue("Coffee", out double price))
            {
                Console.WriteLine($"Price: ${price:F2}");
            }

            // How can I update price value for any item
            menu["Coffee"] = 3.99;

            // check the updated price
            Console.WriteLine("New price of coffee: "+menu["Coffee"]);


            // Remove the item 
            bool removed = menu.Remove("Coffee");

            // Remove returns a Boolean indicating whether the key was removed or not

            Console.WriteLine($"Removed status : {removed}");


            // Display the entire menu using foreach 
            Console.WriteLine("Display the entire menu ");
            foreach (KeyValuePair<string, double> item in menu )
            {
                Console.WriteLine($" {item.Key}  {item.Value}");
            }

            // Alternative : var 
            foreach (var item in menu)
            {
                Console.WriteLine($" ({item.Key}) : ({item.Value})");
            }

            // Count property and Clear() method is there: Purpose is clear from the name

            // Keys
            // // Iterating through keys/ values is also possible
            Console.WriteLine("Printing Keys only");

            foreach (string itemname in menu.Keys)
            {
                Console.WriteLine(itemname);
            }

            Console.WriteLine("Printing values only");

            foreach (double itemprice in menu.Values)
            {
                Console.WriteLine(itemprice);
            }
        }
    }
}
