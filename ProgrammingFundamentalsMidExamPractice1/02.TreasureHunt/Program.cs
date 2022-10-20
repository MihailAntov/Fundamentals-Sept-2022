using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.TreasureHunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> chest = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input;

            while ((input = Console.ReadLine())!= "Yohoho!")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = cmdArgs[0];

                if (command == "Loot")
                {
                    for (int i = 1; i <cmdArgs.Length; i++ )
                    {
                        if (!chest.Contains(cmdArgs[i]))
                        {
                            chest.Insert(0,cmdArgs[i]); 
                        }
                    }
                }
                else if (command == "Drop")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (index < 0 || index >= chest.Count)
                    {
                        continue;
                    }
                    chest.Add(chest[index]);
                    chest.RemoveAt(index);
                }
                else if (command == "Steal")
                {
                    int count = int.Parse(cmdArgs[1]);
                    List<string> stolenItems = new List<string>();
                    int sizeOfChestBeforeTheft = chest.Count; 
                    for (int i = 0; i < Math.Min(sizeOfChestBeforeTheft, count); i++)
                    {
                        stolenItems.Add(chest.Last());
                        chest.Remove(chest.Last());
                    }
                    stolenItems.Reverse();
                    Console.WriteLine(String.Join(", ", stolenItems));
                    
                }
                
            }
            
            if (chest.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                int totalLength = String.Join("", chest).Length;
                decimal avgTreasureGain = (1.0M * totalLength) / chest.Count;

                Console.WriteLine($"Average treasure gain: {avgTreasureGain:f2} pirate credits.");
            }
        }
    }
}
