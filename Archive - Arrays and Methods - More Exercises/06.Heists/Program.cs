using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.Heists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal[] prices = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(n=> decimal.Parse(n))
                .ToArray();
            decimal jewelPrice = prices[0];
            decimal goldPrice = prices[1];

            decimal totalEarnings = 0;
            decimal totalExpenses = 0;
            Dictionary<string, int> lootAmounts = new Dictionary<string, int>
                {
                    {"jewels", 0 },
                    {"gold", 0 }
                };
            string input;
            while((input = Console.ReadLine())!= "Jail Time")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string loot = cmdArgs[0];
                decimal expenses = decimal.Parse(cmdArgs[1]);
                totalExpenses += expenses;
                

                foreach(char c in loot)
                {
                    if(c == '%')
                    {
                        lootAmounts["jewels"]++;
                    }

                    if (c == '$')
                    {
                        lootAmounts["gold"]++;
                    }
                }

            }

            totalEarnings = lootAmounts["gold"] * goldPrice + lootAmounts["jewels"] * jewelPrice;

            if(totalEarnings >= totalExpenses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalEarnings-totalExpenses}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {Math.Abs(totalEarnings-totalExpenses)}.");
            }
        }
    }
}
