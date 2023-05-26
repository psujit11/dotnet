using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class List
    {
        static public void Lst()
        {
            List<int> numbers = new List<int>();

            //Add
            numbers.Add(1);
            numbers.Add(2);
            int[] arr = { 3, 5 };
            numbers.AddRange(arr);

            //Insert
            numbers.Insert(3, 6);
            int[] arr2 = { 15, 51 };
            numbers.InsertRange(3, arr2);

            //Remove
            numbers.Remove(3);
            numbers.RemoveAt(5);
            numbers.RemoveRange(1, 2);

            Console.WriteLine($"Contains 25? => {numbers.Contains(25)}");
        }
    }
}
