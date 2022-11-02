using System;

namespace _01.ConvertMetersТoKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            Console.WriteLine($"{(double)meters/1000.0:f2}");
        }
    }
}
