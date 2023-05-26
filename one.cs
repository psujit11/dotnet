using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class one
    {
      static public void Product()
            {
                int a, b, c, d, prod;
                Console.Write("Enter the first number: ");
                a = Int16.Parse(Console.ReadLine());
                Console.Write("Enter the second number: ");
                b = Int16.Parse(Console.ReadLine());
                Console.Write("Enter the third number: ");
                c = Int16.Parse(Console.ReadLine());
                Console.Write("Enter the fourth number: ");
                d = Int16.Parse(Console.ReadLine());
                prod = a * b * c * d;
                Console.WriteLine($"Product of {a}, {b}, {c}, {d} is {prod}");
            }
     }
}

