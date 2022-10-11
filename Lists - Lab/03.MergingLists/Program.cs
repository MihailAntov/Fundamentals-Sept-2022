using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> firstList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            List<double> secondList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            MergeLists(firstList, secondList);
        }

        static void MergeLists(List<double> firstList, List<double> secondList)
        {
            List<double> result = new List<double>();

            for (int i = 0; i < Math.Min(firstList.Count, secondList.Count); i++)
            {
                result.Add(firstList[i]);
                result.Add(secondList[i]);
            }

            for (int i = Math.Min(firstList.Count, secondList.Count); i < Math.Max(firstList.Count, secondList.Count); i ++)
            {
                if (firstList.Count > secondList.Count)
                {
                    result.Add(firstList[i]);
                }
                else
                {
                    result.Add(secondList[i]);
                }
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
