using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();

            SortedDictionary<int, int> numbers = new SortedDictionary<int, int>();

            foreach(int i in integers)
            {
                if(numbers.ContainsKey(i))
                {
                    numbers[i]++;
                }
                else
                {
                    numbers.Add(i, 1);
                }
            }

            foreach(KeyValuePair<int,int> i in numbers)
            {
                Console.WriteLine($"{i.Key} -> {i.Value}");
            }

        }
    }
}
