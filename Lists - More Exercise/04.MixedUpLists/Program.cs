using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.MixedUpLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> firstLine = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => double.Parse(n))
                .ToList();

            List<double> secondLine = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => double.Parse(n))
                .ToList();

            List<double> mixedLine = new List<double>();
            for (int i = 0; i < Math.Min(firstLine.Count, secondLine.Count); i++)
            {
                mixedLine.Add(firstLine[i]);
                mixedLine.Add(secondLine[secondLine.Count - 1 - i]);
            }

            List<double> resultRange;
            if ( firstLine.Count > secondLine.Count)
            {
                //range is in firstLine
                resultRange = new List<double> { firstLine[firstLine.Count - 2], firstLine[firstLine.Count - 1]};
            }
            else
            {
                //range is in secondLine
                resultRange = new List<double> { secondLine[0], secondLine[1] };
            }
            resultRange.Sort();
            List<double> result = mixedLine.Where(n => n > resultRange[0] && n < resultRange[1]).ToList();
            result.Sort();

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
