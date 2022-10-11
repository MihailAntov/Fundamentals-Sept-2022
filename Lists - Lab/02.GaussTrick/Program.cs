using System;
using System.Linq;
using System.Collections.Generic;
namespace _02.GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            GaussTrick(numbers);

        }

        static void GaussTrick(List<double> numbers)
        {
            int originalCount = numbers.Count;
            for (int i = 0; i < originalCount/2; i++)
            {
                numbers[i] += numbers[originalCount - 1 - i];
                numbers.RemoveAt(originalCount - 1 - i);
            }

            Console.WriteLine(String.Join(" ", numbers));

        }
    }
}
