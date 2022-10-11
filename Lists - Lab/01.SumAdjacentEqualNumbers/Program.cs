using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.SumAdjacentEqualNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <double> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList<double>();
            SumAdjacentNumbers(numbers);

            Console.WriteLine(String.Join(" ", numbers));

        }

        static void SumAdjacentNumbers(List<double> list)
        {
            bool requireNewPass = false;
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i-1] == list[i])
                {
                    list[i] += list[i - 1];
                    list.RemoveAt(i - 1);
                    requireNewPass = true; 
                    
                }
            }

            if (requireNewPass)
            {
                SumAdjacentNumbers(list);
            }
        }


    }
}
