using System;
using System.Collections.Generic;

namespace _03.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, int> resources = new Dictionary<string, int>();
            while ((input = Console.ReadLine()) != "stop")
            {
                string resource = input;
                int amount = int.Parse(Console.ReadLine());

                if(!resources.ContainsKey(resource))
                {
                    resources.Add(resource, 0);
                }

                resources[resource] += amount;
            }

            foreach(KeyValuePair<string, int> entry in resources)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }
    }
}
