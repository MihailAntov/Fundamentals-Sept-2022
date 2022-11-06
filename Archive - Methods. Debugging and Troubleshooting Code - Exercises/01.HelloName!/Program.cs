using System;

namespace _01.HelloName_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintHello(Console.ReadLine());
        }

        public static void PrintHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
