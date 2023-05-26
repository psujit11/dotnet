using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Five
    {
        public static void Mul()
        {
            int i, j;
            Console.Write("Enter no. of rows for matrix A: ");
            int m = Int16.Parse(Console.ReadLine());
            Console.Write("Enter no. of columns for matrix A: ");
            int n = Int16.Parse(Console.ReadLine());
            Console.Write("Enter no. of rows for matrix B: ");
            int p = Int16.Parse(Console.ReadLine());
            Console.Write("Enter the no. of columns for matrix B: ");
            int q = Int16.Parse(Console.ReadLine());

            int[,] result = new int[m, q];
            int[,] arrayA = new int[m, n];
            int[,] arrayB = new int[p, q];
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.WriteLine($"Enter element of matrixA[{i}][{j}]");
                    arrayA[i, j] = Int16.Parse(Console.ReadLine());
                }
            }
            for (i = 0; i < p; i++)
            {
                for (j = 0; j < q; j++)
                {
                    Console.WriteLine($"Enter element of matrixB[{i}][{j}]");
                    arrayB[i, j] = Int16.Parse(Console.ReadLine());
                }
            }

            for (i = 0; i < arrayA.GetLength(0); i++)
            {
                for (j = 0; j < arrayB.GetLength(1); j++)
                {
                    for (int k = 0; k < arrayA.GetLength(1); k++)
                    {
                        result[i, j] = result[i, j] + arrayA[i, k] * arrayB[k, j];
                    }
                }
            }

            Console.WriteLine("Result:");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < q; j++)
                {
                    Console.Write($"{result[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
