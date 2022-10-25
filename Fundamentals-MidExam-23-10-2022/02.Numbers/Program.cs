using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "Finish")
            {
                string[] commandArguments = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = commandArguments[0];
                int value = int.Parse(commandArguments[1]);
                switch (command)
                {
                    case "Add":
                        numbers.Add(value);
                        break;
                    case "Remove":
                        numbers.Remove(value);
                        break;
                    case "Replace":
                        int replacement = int.Parse(commandArguments[2]);
                        if(numbers.Contains(value))
                        {
                            numbers[numbers.IndexOf(value)] = replacement;
                        }
                        
                        break;
                    case "Collapse":
                        numbers.RemoveAll(n => n < value);
                        break;
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
