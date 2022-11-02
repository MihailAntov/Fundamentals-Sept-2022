using System;

namespace _09.SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;
            int i = 1;
            while (counter < n)
            {
                if (i%2!= 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                    counter++;
                    i += 2;
                }
                else
                {
                    i++;
                }
                

            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
