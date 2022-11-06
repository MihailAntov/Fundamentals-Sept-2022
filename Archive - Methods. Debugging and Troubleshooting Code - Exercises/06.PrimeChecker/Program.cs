using System;

namespace _06.PrimeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(n));
        }

        public static bool IsPrime(long n)
        {
            if(n == 2)
            {
                return true;
            }

            if(n == 0 || n == 1)
            {
                return false;   
            }
            
            if(n % 2 == 0)
            {
                return false;
            }

            for (int i = 3; i <= Math.Sqrt(n); i+= 2)
            {
                if(n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
