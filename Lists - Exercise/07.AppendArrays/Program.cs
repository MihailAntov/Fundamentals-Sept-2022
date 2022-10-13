using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrays = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);

            List<int> result = new List<int>();

            for (int i = arrays.Length-1; i >= 0; i--)
            {
                int[] numbers = arrays[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => int.Parse(n))
                    .ToArray();

                foreach (int n in numbers)
                {
                    result.Add(n);
                }
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
