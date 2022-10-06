using System;

namespace _03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case "add":
                    Console.WriteLine(Add(a, b));
                    break;
                case "multiply":
                    Console.WriteLine(Multiply(a, b));
                    break;
                case "subtract":
                    Console.WriteLine(Subtract(a, b));
                    break;
                case "divide":
                    Console.WriteLine(Divide(a, b));
                    break;
            }
        }
        private static int Add(int a, int b)
        {
            return a + b; ;
        }
        private static int Multiply(int a, int b)
        {
            return a * b;
        }
        private static int Subtract(int a, int b)
        {
            return a - b;
        }
        private static int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
