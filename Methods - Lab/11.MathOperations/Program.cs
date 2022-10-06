using System;

namespace _11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(firstNumber, secondNumber, operation));
        }

        static double Calculate(double a, double b, string operation)
        {
            switch (operation)
            {
                case "/":
                    return a / b;
                case "*":
                    return a * b;
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                default:
                    return 0;
            }
        }
    }
}
