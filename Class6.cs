using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Queue
    {
        static public void Qe()
        {
            Queue<int> numbers = new Queue<int>();

            numbers.Enqueue(2);
            numbers.Enqueue(4);
            numbers.Enqueue(6);
            numbers.Enqueue(10);
            numbers.Enqueue(8);

            Console.WriteLine($"Queue Rear = {numbers.Peek()}");

            numbers.Dequeue();
            Console.WriteLine("After Dequeuing");
            Console.WriteLine($"Queue Rear  = {numbers.Peek()}");

            Console.WriteLine($"No. of Elements = {numbers.Count}");

            bool a = numbers.Contains(6);
            Console.WriteLine($"Contains 6? => {a}");

            numbers.Clear();
            Console.WriteLine("After Clearing");
            Console.WriteLine($"No. of Elements = {numbers.Count}");
        }
    }

}
