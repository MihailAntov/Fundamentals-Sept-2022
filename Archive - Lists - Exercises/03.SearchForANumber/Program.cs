using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SearchForANumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToList();

            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();

            int toTake = nums[0];
            int toDelete = nums[1];
            int numberToSearchFor = nums[2];

            input = input.Take(toTake).ToList();
            input.RemoveRange(0, toDelete);
            if(input.Contains(numberToSearchFor))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
