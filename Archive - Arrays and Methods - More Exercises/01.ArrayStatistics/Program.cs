using System;
using System.Linq;
namespace _01.ArrayStatistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(n => int.Parse(n))
                .ToArray();

            Console.WriteLine($"Min = {nums.Min()}");
            Console.WriteLine($"Max = {nums.Max()}");
            long sum = 0;
            foreach (int n in nums)
            {
                sum += n;
            }
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {nums.Average()}");
            //passes as c# code
        }
    }
}
