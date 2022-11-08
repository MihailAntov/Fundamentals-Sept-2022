using System;
using System.Numerics;

namespace _13.Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(n));
        }
        

        public static BigInteger Factorial(int number)
        {
            BigInteger result = 1;
            for(int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
