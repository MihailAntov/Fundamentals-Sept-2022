using System;

namespace _04.RefactoringPrimeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int upperLimit = int.Parse(Console.ReadLine());
            for (int i = 2; i <= upperLimit; i++)
            {
                bool isPrime = true;
                for (int divisor = 2; divisor < i; divisor++)
                {
                    if (i % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isPrime.ToString().ToLower()}");
            }
        }
    }
}
