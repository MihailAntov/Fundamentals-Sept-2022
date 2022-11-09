using System;
using System.Linq;
namespace _01.ArrayStatistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();

            Console.WriteLine($"Min = {nums.Min()}");
            Console.WriteLine($"Max = {nums.Max()}");
            Console.WriteLine($"Sum = {nums.Sum()}");
            Console.WriteLine($"Average = {nums.Average()}");
        }
    }
}
