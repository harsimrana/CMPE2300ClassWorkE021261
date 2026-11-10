using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week08Day02QueueStackDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Queue - will follow FIFO [First in First Out]

            // The first item added into the collection  is the first item removed/served

            Queue<string> customers = new Queue<string>();

            // To add a new item into Queue  : Enqueue() : Add an item to the back of the queue

            customers.Enqueue("JOHN");
            customers.Enqueue("Simran");
            customers.Enqueue("Steven");
            customers.Enqueue("Carlos");

            foreach (string c in customers)
                Console.WriteLine(c);

            // Dequeue() - removes and returns the item at the front 

            //string customer = customers.Dequeue();

            // Sometimes you want to look at the first item without removing it

            string customer1 = customers.Peek();

            Console.WriteLine($"Customer served : " + customer1);

            //Console.WriteLine($"Customer served : " +customer);

            foreach (string c in customers)
                Console.WriteLine(c);

            // Clear() Contains() COUNT 
            // TryPeek() TryDequeue()

            // STACK 
            // LIFO - Last in First Out 
            // The last item added in the list is first one removed/served

            Stack<string> plates = new Stack<string>();

            //plates.Push("plate 1 ");
            //plates.Push("plate 2 ");
            //plates.Push("plate 3 ");

            foreach (string p in plates)
            {
                Console.WriteLine(p);
            }

            // Pop() - removes and returns the top item from your stack

            string plate = plates.Pop();

            Console.WriteLine("TOP pulled item :" + plate);

            Console.WriteLine("Remaining stack ");
            foreach (string p in plates)
            {
                Console.WriteLine(p);
            }

            // You can also use Peek()
            // TryPop() - in the latest version


        }
    }
}
