using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Twoe
    {
        public static void Loop()
        {
            string name;
            Console.Write("Enter Your name: ");
            name = Console.ReadLine();
            foreach (char letter in name)
            {
                Console.WriteLine(letter);
            }
        }
    }
}
