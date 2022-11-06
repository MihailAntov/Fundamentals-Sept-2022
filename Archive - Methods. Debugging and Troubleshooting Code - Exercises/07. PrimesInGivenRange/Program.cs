using System;
using System.Collections.Generic;
namespace _07._PrimesInGivenRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine(String.Join(", ", GetPrimesInRange(start, end)));
        }

        public static List<int> GetPrimesInRange(int start, int end)
        {
            List<int> primes = new List<int>();
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }
            return primes;

        }

        public static bool IsPrime(int n)
        {
            if(n == 0 || n == 1)
            {
                return false;
            }
            if(n == 2)
            {
                return true;
            }

            if (n % 2 == 0)
            {
                return false;
            }

            for (int i = 3; i <= Math.Sqrt(n); i++)
            {
                if(n%i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
