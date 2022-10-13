using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            
            string input;
            bool changed = false;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = input.Split(" ");

                
                switch (cmdArgs[0])
                {
                    case "Add":
                        Add(numbers, int.Parse(cmdArgs[1]));
                        changed = true;
                        break;
                    case "Remove":
                        Remove(numbers, int.Parse(cmdArgs[1]));
                        changed = true;
                        break;
                    case "RemoveAt":
                        RemoveAt(numbers, int.Parse(cmdArgs[1]));
                        changed = true;
                        break;
                    case "Insert":
                        Insert(numbers, int.Parse(cmdArgs[1]), int.Parse(cmdArgs[2]));
                        changed = true;
                        break;
                    case "Contains":
                        Contains(numbers, int.Parse(cmdArgs[1]));
                        break;
                    case "PrintEven":
                        PrintEven(numbers);
                        break;
                    case "PrintOdd":
                        PrintOdd(numbers);
                        break;
                    case "GetSum":
                        GetSum(numbers);
                        break;
                    case "Filter":
                        Filter(numbers, cmdArgs[1], int.Parse(cmdArgs[2]));
                        break;
                }
            }

            if (changed)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
        }

        static void Contains(List<int> list, int number)
        {
            bool containsNumber = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == number)
                {
                    containsNumber = true;
                    break;
                }
            }

            if(containsNumber)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }

        static void PrintEven(List<int> list)
        {
            List<int> results = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i]%2 == 0)
                {
                    results.Add(list[i]);
                }
            }

            Console.WriteLine(String.Join(" ", results));
        }

        static void PrintOdd(List<int> list)
        {
            List<int> results = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 != 0)
                {
                    results.Add(list[i]);
                }
            }

            Console.WriteLine(String.Join(" ", results));
        }

        static void GetSum(List<int> list)
        {
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }

            Console.WriteLine(sum);
        }

        static void Filter(List<int> list, string condition, int number)
        {
            List<int> results = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                switch (condition)
                {
                    case "<":
                        if(list[i] < number)
                        {
                            results.Add(list[i]);
                        }
                        break;
                    case ">":
                        if (list[i] > number)
                        {
                            results.Add(list[i]);
                        }
                        break;
                    case "<=":
                        if (list[i] <= number)
                        {
                            results.Add(list[i]);
                        }
                        break;
                    case ">=":
                        if (list[i] >= number)
                        {
                            results.Add(list[i]);
                        }
                        break;
                }
            }

            Console.WriteLine(String.Join(" ", results));
        }

        static void Add(List<int> list, int number)
        {
            list.Add(number);
            
        }

        static void Remove(List<int> list, int number)
        {
            list.Remove(number);
        }

        static void RemoveAt(List<int> list, int index)
        {
            list.RemoveAt(index);
        }

        static void Insert(List<int> list, int number, int index)
        {
            list.Insert(index, number);
        }

        static void PrintList(List<int> list)
        {
            Console.WriteLine(String.Join(" ", list));
        }
    }
}
