using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week07DemoExtensionMethods
{
    internal static class NumberExtenstions
    {
        public static string ToFixed2(this double value) =>
            Math.Round(value, 2).ToString();

        public static string ToFixed(this double value, int digits) =>
            Math.Round(value, digits).ToString();
    }
}
