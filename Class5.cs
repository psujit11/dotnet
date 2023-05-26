using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Stack
    {
        static public void Stax()
        {
            Stack<int> numbers = new Stack<int>();

            numbers.Push(3);
            numbers.Push(5);
            numbers.Push(7);
            numbers.Push(11);
            numbers.Push(9);

            Console.WriteLine($"Top of stack = {numbers.Peek()}");

            numbers.Pop();
            Console.WriteLine("After Popping");
            Console.WriteLine($"Top of stack = {numbers.Peek()}");

            Console.WriteLine($"No. of Elements = {numbers.Count}");

            bool a = numbers.Contains(15);
            Console.WriteLine($"Contains 15? => {a}");

            numbers.Clear();
            Console.WriteLine("After Clearing");
            Console.WriteLine($"No. of Elements = {numbers.Count}");
        }
    }
}
