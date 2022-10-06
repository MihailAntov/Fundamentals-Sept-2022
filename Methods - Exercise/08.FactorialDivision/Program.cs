using System;

namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            DivideFactorials(a, b);
        }

        static double Factorial (int n)
        {
            double result = 1;
            
            for (int i = 2; i <= n; i++)
            {
                result *=  i;
            }

            return result * 1.0;
        }

        static void DivideFactorials (int a, int b)
        {
            Console.WriteLine($"{Factorial(a) / Factorial(b):f2}");
        }
    }
}
