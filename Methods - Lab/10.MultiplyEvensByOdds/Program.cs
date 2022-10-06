using System;

namespace _10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultipleOfEvenAndOdds(number));
            
        }
        static int GetMultipleOfEvenAndOdds(int n)
        {
            return (GetSumOfEvenDigits(n) * GetSumOfOddDigits(n));
        }

        static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            int currentChar;
            if (n / 10 != 0)
            {
                sum += GetSumOfEvenDigits(n / 10);
            }

            currentChar = n % 10;

            if (currentChar % 2 == 0)
            {
                sum += currentChar;
            }

            return sum;
        }

        static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            int currentChar;
            if (n / 10 != 0)
            {
                sum += GetSumOfOddDigits(n / 10);
            }

            currentChar = n % 10;

            if (currentChar % 2 != 0)
            {
                sum += currentChar;
            }

            return sum;
        }
    }
}
