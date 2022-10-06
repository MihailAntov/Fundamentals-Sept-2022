using System;
using System.Linq;

namespace _06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int sumLeft = 0;
                int sumRight = 0;

                for (int j = 0; j < i; j++)
                {
                    sumLeft += numbers[j];
                }

                for (int j = i+1; j < numbers.Length; j++)
                {
                    sumRight += numbers[j];
                }

                if(sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    break;
                }
                
                if (i == numbers.Length-1)
                {
                    Console.WriteLine("no");
                }
            }
        }
    }
}
