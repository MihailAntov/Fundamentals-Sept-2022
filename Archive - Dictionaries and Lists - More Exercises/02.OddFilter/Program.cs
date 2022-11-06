using System;
using System.Linq;

namespace _02.OddFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .Where(n => n % 2 == 0)
                .ToArray();

            double average = ints.Select(n=>(double)n).Average();
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] > average)
                {
                    ints[i]++;
                }
                else if (ints[i] < average)
                {
                    ints[i]--;
                }
            }

            Console.WriteLine(String.Join(" ",ints));
        }
    }
}
