using System;

namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculateLowest(a, b, c));

        }

        static int CalculateLowest(int a, int b, int c)
        {
            return Math.Min(Math.Min(a, b), c);
        }
    }
}
