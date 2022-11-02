using System;

namespace _03.ExactSumOfRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal sum = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);



        }
    }
}
