using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class twob
    {
       
            static public void Cal()
            {
                Console.WriteLine("Enter two numbers:");
                Console.Write("Enter a:");
                int a = Int16.Parse(Console.ReadLine());
                Console.Write("Enter b:");
                int b = Int16.Parse(Console.ReadLine());

                Console.WriteLine($"Sum = {a + b}");
                Console.WriteLine($"Difference = {b - a}");
                Console.WriteLine($"Product = {a * b}");
                Console.WriteLine($"Remainder = {a % b}");
            }
       }
 }

