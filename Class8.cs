using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Dictonary
    {
        static public void Dict()
        {
            Dictionary<string, int> prices = new Dictionary<string, int>();

            prices.Add("a", 100);
            prices.Add("b", 200);

            Console.WriteLine($"Price of a = {prices["a"]}");
            Console.WriteLine($"Item having price of {prices.ElementAt(1).Value} = {prices.ElementAt(1).Key}");

            prices["a"] = 400;
            Console.WriteLine($"Updated price of a = {prices["a"]}");

            prices.Remove("a");
            Console.WriteLine($"No. of items = {prices.Count}");

            prices.Clear();
            Console.WriteLine($"No. of items = {prices.Count}");
        }
    }
}
