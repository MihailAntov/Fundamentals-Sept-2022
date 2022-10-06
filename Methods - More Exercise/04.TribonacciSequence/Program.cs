using System;


namespace _04.TribonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            CalculateTribonacci(n);

        }

        static void CalculateTribonacci(int n)
        {
            int[] numbers = new int[n];
            
            
            for (int i = 1; i <= n; i++)
            {
                if (i==1)
                {
                    Console.Write(1+" ");
                    numbers[i - 1] = 1;
                    continue;
                }

                if (i==2)
                {
                    Console.Write(1 + " ");
                    numbers[i - 1] = 1;
                    continue;
                }

                if (i == 3)
                {
                    Console.Write(2+" ");
                    numbers[i - 1] = 2;
                    continue;
                }

                numbers[i - 1] = numbers[i - 2] + numbers[i - 3] + numbers[i - 4];
                Console.Write($"{numbers[i-1]} ");

                
            }
        }
    }
}
