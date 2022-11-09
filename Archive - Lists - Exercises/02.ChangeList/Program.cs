using System;
using System.Collections.Generic;
using System.Linq;
namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "Odd" && (input != "Even"))
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];

                int element = int.Parse(cmdArgs[1]);
                if(command == "Delete")
                {
                    ints.RemoveAll(n=>n==element);
                }
                else if (command == "Insert")
                {
                    int position = int.Parse(cmdArgs[2]);
                    ints.Insert(position, element); 
                }
            }

            if(input == "Even")
            {
                Console.WriteLine(String.Join(" ",ints.Where(n=>n%2 == 0).ToList()));
            }
            else
            {
                Console.WriteLine(String.Join(" ", ints.Where(n => n % 2 != 0).ToList()));
            }
        }
    }
}
