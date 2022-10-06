using System;

namespace _03.FloatingEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());

            double margin = 0.000001;

            if (Math.Abs(numberA - numberB) < margin)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
