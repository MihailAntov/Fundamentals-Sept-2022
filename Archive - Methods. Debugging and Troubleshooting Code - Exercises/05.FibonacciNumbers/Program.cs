using System;

namespace _05.FibonacciNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Fib(n);
        }

        public static void Fib(int n)
        {
            int[] numbers = new int[n+1];

            
            numbers[0] = 1;
            
            if (n >= 1)
            {
                numbers[1] = 1;
            }

            for (int i = 2; i <= n; i++)
            {
                numbers[i] = numbers[i - 1] + numbers[i - 2];
            }

            Console.WriteLine(numbers[n]);


        }
    }
}
