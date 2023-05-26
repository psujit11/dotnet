using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Four
    {
        public static void Jag()
        {
            int sum = 0;
            int[][] jagged = new int[3][];
            jagged[0] = new int[] { 3, 2, 1, 5, 0 };
            jagged[1] = new int[] { 27, 32, 24, 41, 2, 61 };
            jagged[2] = new int[] { 4, 60, 1, 12 };

            foreach (int[] arr in jagged)
            {
                foreach (int val in arr)
                {
                    sum += val;
                }
            }
            Console.WriteLine($"Sum is {sum}");
        }
    }
}
