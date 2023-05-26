using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Quadrant
    {

        public static void Quad()
        {
            decimal x, y;
            Console.Write("Enter the value of x: ");
            x = decimal.Parse(Console.ReadLine()!);
            Console.Write("Enter the value of y: ");
            y = decimal.Parse(Console.ReadLine()!);
            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origin");
            }
            else if (x == 0)
            {
                Console.WriteLine("Y-axis");
            }
            else if (y == 0)
            {
                Console.WriteLine("X-axis");
            }

            else if (x < 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("First Quadrant");
                }
                else
                {
                    Console.WriteLine("Third Quadrant");
                }
            }
            else
            {
                if (y > 0)
                {
                    Console.WriteLine("Second Quadrant");
                }
                else
                {
                    Console.WriteLine("Fourth Quadrant");
                }
            }
        }
    }
}
