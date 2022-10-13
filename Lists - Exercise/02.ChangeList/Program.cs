using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
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

                switch (cmdArgs[0])
                {
                    case "Delete":

                        numbers.RemoveAll(n => n.Equals(int.Parse(cmdArgs[1])));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(cmdArgs[2]), int.Parse(cmdArgs[1]));
                        break;
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
