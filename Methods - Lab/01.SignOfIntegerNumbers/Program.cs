using System;

namespace _01.SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            CheckNumber(n);
        }
        static void CheckNumber(int n)
        {
            if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else
            {
                Console.WriteLine($"The number {n} is zero.");
            }
        }
    }
}
