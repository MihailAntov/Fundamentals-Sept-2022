using System;
using System.Collections.Generic;

namespace _03.GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //OutFall 4                     $39.99
            //CS: OG                        $15.99
            //Zplinter Zell	                $19.99
            //Honored 2                     $59.99
            //RoverWatch                    $29.99
            //RoverWatch Origins Edition    $39.99

            decimal balance = decimal.Parse(Console.ReadLine());
            decimal totalSpent = 0.0M;
            Dictionary<string, decimal> prices = new Dictionary<string, decimal>() { 
                {"OutFall 4", 39.99M},
                {"CS: OG", 15.99m},
                {"Zplinter Zell", 19.99m},
                {"Honored 2", 59.99m},
                {"RoverWatch", 29.99m},
                {"RoverWatch Origins Edition", 39.99m}
            };

            string command = string.Empty;
            while (command != "Game Time")
            {
                command = Console.ReadLine();
                if (command == "Game Time")
                {
                    Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${balance:f2}");
                    break;
                }
                if(prices.ContainsKey(command))
                {
                    if(prices[command] > balance)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought {command}");
                        balance -= prices[command];
                        totalSpent += prices[command];
                    }

                    if(balance == 0.0M)
                    {
                        Console.WriteLine("Out of money!");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
            }
            
        }
    }
}
