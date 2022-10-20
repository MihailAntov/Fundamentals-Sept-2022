using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_02.ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine()
                .Split("!", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input;

            while ((input = Console.ReadLine())!= "Go Shopping!")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = cmdArgs[0];

                switch (command)
                {
                    case "Urgent":
                        string itemToBeAdded = cmdArgs[1];
                        if (!groceries.Contains(itemToBeAdded))
                        {
                            groceries.Insert(0, itemToBeAdded);
                        }
                        break;
                    case "Unnecessary":
                        string itemToBeRemoved = cmdArgs[1];
                        groceries.Remove(itemToBeRemoved);
                        break;
                    case "Correct":
                        if (groceries.Contains(cmdArgs[1]))
                        {
                            int indexOfOldItem = groceries.IndexOf(cmdArgs[1]);
                            groceries[indexOfOldItem] = cmdArgs[2];
                        }
                        
                        break;
                    case "Rearrange":
                        if(groceries.Contains(cmdArgs[1]))
                        {
                            groceries.Add(cmdArgs[1]);
                            groceries.Remove(cmdArgs[1]);
                        }
                        break;
                }
            }

            Console.WriteLine(String.Join(", ",groceries));
        }
    }
}
