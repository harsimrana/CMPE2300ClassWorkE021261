using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week07DemoExtensionMethods
{
    internal static class SequenceExtensions
    {
        public static void PrintItems<T>(this IEnumerable<T> source, string label)
        {
            Console.Write(label);
            Console.WriteLine(string.Join(", ", source));
        }
    }
}
