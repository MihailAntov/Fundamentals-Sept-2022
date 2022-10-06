using System;

namespace _04.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);

        }

        static void PrintTriangle (int n)
        {
            int rows = 2* n - 1;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= Math.Min(i, rows - i + 1); j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
