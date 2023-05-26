using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Three
    {
        public static void Large()
        {
            int[] arr = { 70, 64, 97, 84, 51, 29 };
            arr = arr.Where(val => val != arr.Max()).ToArray();
            Console.WriteLine($"The Second largest value is {arr.Max()}");
        }
    }
}
