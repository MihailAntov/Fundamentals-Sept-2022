using System;

namespace _06.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculateRectangleArea(a, b));
        }
        static int CalculateRectangleArea(int a, int b)
        {
            return a * b;
        }
    }
}
