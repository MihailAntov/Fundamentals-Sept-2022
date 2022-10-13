using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split(' ');
                switch(cmdArgs[0])
                {
                    case "Add":
                        Add(numbers, int.Parse(cmdArgs[1]));
                        break;
                    case "Remove":
                        Remove(numbers, int.Parse(cmdArgs[1]));
                        break;
                    case "RemoveAt":
                        RemoveAt(numbers, int.Parse(cmdArgs[1]));
                        break;
                    case "Insert":
                        Insert(numbers, int.Parse(cmdArgs[1]), int.Parse(cmdArgs[2]));
                        break;
                }

            }

            PrintList(numbers);
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
