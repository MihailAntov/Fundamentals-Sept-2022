using System;

namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTopIntegerRange(n);
        }

        static void PrintTopIntegerRange(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (TopInteger(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool TopInteger (int n)
        {
            
            bool hasOddDigit = false;
            int sumOfDigits = 0;
            while (n / 10 != 0)
            {
                int currentDigit = n % 10;
                n /= 10;
                sumOfDigits += currentDigit;
                if (currentDigit % 2 != 0)
                {
                    hasOddDigit = true;
                }

            }
            sumOfDigits += n % 10;
            if ((n % 10) % 2 != 0)
            {
                hasOddDigit = true;
            }

            bool sumDivisible = sumOfDigits % 8 == 0;

            if (hasOddDigit && sumDivisible)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
