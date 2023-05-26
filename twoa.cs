using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Pythagorus
    {
       
            public static void Dynam()
            {
                double p, b, h;
                Console.Write("Enter the perpendicular length: ");
                p = double.Parse(Console.ReadLine());
                Console.Write("Enter the base length: ");
                b = double.Parse(Console.ReadLine());
                h = Math.Sqrt((p * p) + (b * b));
                Console.WriteLine($"The hypotenuse is {h}");
            }
        }
    }



