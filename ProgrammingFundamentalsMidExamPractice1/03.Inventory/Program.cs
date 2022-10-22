using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input;

            while ((input = Console.ReadLine())!= "Craft!")
            {
                string[] cmdArgs = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];

                switch (command)
                {
                    case "Collect":
                        string collectedItem = cmdArgs[1];
                        if(items.Contains(collectedItem))
                        {
                            continue;
                        }
                        items.Add(collectedItem);
                        break;

                    case "Drop":
                        string itemToBeDroppped = cmdArgs[1];
                        items.Remove(itemToBeDroppped);
                        break;
                    case "Combine Items":
                        string[] itemsToBeCombined = cmdArgs[1].Split(":",StringSplitOptions.RemoveEmptyEntries);
                        string oldItem = itemsToBeCombined[0];
                        string newItem = itemsToBeCombined[1];
                        if(items.Contains(oldItem))
                        {
                            items.Insert(items.IndexOf(oldItem)+1, newItem);
                        }
                        break;
                    case "Renew":
                        string itemToBeRenewed = cmdArgs[1];
                        if (items.Contains(itemToBeRenewed))
                        {
                            items.Remove(itemToBeRenewed);
                            items.Add(itemToBeRenewed);
                        }
                        break;

                }
            }

            Console.WriteLine(String.Join(", ",items));
        }
    }
}
