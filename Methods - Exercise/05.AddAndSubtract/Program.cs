using System;

namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(SubtractThird(SumFirstTwo(a, b), c));

        }

        static int SumFirstTwo(int a, int b)
        {
            return a + b;
        }

        static int SubtractThird (int ab, int c)
        {
            return ab - c;
        }
    }
}
