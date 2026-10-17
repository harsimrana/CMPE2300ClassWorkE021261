using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week07DemoExtensionMethods
{
    internal static class StringExtensions
    {
        public static int CountWords(this string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return 0;

            // Logic to calcualte number of words

            return text.Split( new char[] {' ','\n', '\r','\t' }, StringSplitOptions.RemoveEmptyEntries).Length;

        }
    }
}
