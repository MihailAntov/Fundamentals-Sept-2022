using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SantasNewList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, Dictionary<string, int>> goodKids = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> toys = new Dictionary<string, int>();
            while ((input = Console.ReadLine())!= "END")
            {
                string[] inputArgs = input.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                
                if (inputArgs.Length == 2)
                {
                    string naughtyKid = inputArgs[1];
                    if(goodKids.ContainsKey(naughtyKid))
                    {
                        goodKids.Remove(naughtyKid);
                    }
                }
                else if (inputArgs.Length == 3)
                {
                    string kid = inputArgs[0];
                    string present = inputArgs[1];
                    int amount = int.Parse(inputArgs[2]);

                    if(!goodKids.ContainsKey(kid))
                    {
                        goodKids.Add(kid, new Dictionary<string,int>());
                    }

                    goodKids[kid].Add(present,amount);

                    if(!toys.ContainsKey(present))
                    {
                        toys.Add(present, 0);
                    }
                    toys[present] += amount;
                }
            }

            Console.WriteLine("Children:");
            foreach(KeyValuePair<string, Dictionary<string, int>> kid in goodKids
                .OrderByDescending(n=>n.Value.Values.Sum())
                .ThenBy(n=>n.Key))
            {
                Console.WriteLine($"{kid.Key} -> {kid.Value.Select(n=>n.Value).Sum()}");
            }

            Console.WriteLine("Presents:");
            foreach(KeyValuePair<string, int> toy in toys)
            {
                Console.WriteLine($"{toy.Key} -> {toy.Value}");
            }
        }
    }

    
}
