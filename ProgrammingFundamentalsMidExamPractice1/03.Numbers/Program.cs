using System;
using System.Collections.Generic;
using System.Linq;
namespace _03.Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToList();

            double average = numbers.Average();

            List<int> filteredNumbers = numbers.Where(n => n > average)
                .OrderByDescending(n=>n)
                .Take(5)
                .ToList();

            if (filteredNumbers.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(String.Join(" ", filteredNumbers));
            }


            
        }
    }
}
