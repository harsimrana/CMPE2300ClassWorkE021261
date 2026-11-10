using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListSpaceMissionControl
{
    internal class Program
    {
        static LinkedList<Destination> route = new LinkedList<Destination>();
        static void Main(string[] args)
        {
            Console.WriteLine("== Simran Space Mission ==");

            //1. Create the original Route 
            route.AddLast(new Destination(1, "Earth", "Launch"));
            route.AddLast(new Destination(2, "Mars", "Exploration"));
            route.AddLast(new Destination(3, "Jupiter", "Observation"));

            DisplayRoute();

            //2. Add a new destination at the beginning
            route.AddFirst(new Destination(4, "Moon", "Equipment Test"));

            DisplayRoute();

            //3.  Add a destination to the end 
            route.AddLast(new Destination(5, "Saturn", "Ring Research "));

            DisplayRoute();

            //4.  Insert a destination after Mars
            Console.WriteLine(" Adding an Asternoid station after Mars");

            LinkedListNode<Destination> mars = FindDestination(2);

            if (mars != null)
            {
                route.AddAfter(mars, new Destination(6, "Asteriod Station", "Mineral Study"));
            }

            DisplayRoute();

            LinkedListNode<Destination> jupiter = FindDestination(3);

            if (jupiter != null)
            {
                route.AddBefore(jupiter, new Destination(7, "Refuel Station", "Refuelling : Coffee time spacecraft"));

            }
            DisplayRoute();

            // 6. Remove Mars from the mission
            Console.WriteLine(" Cancelling Mars Mission ");

            // We already has access to mars check line number 36 above

            if (mars != null)
            {
                route.Remove(mars);
            }

            DisplayRoute();

            Console.WriteLine($" How many on the mission : {route.Count} destinations");
            

        }
        // Trying to find a specific destination based on passed destination id
        // It will return the Node in the linked list
        public static LinkedListNode<Destination> FindDestination(int destinationId)
        {
            LinkedListNode<Destination> current = route.Last;

            while (current != null)
            {
                if (current.Value.Id == destinationId)
                {
                    return current;
                }
                current = current.Previous;
            }
            return null;

        }
        public static void  DisplayRoute()
        {
            Console.WriteLine("Current Mission Route");

            LinkedListNode<Destination> current = route.First;

            while (current != null)
            {
                Console.WriteLine(current.Value.ToString());  // Keep in mind the Value will give you reference to object
                current = current.Next;
            }

        }
    }
}
