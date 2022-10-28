using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, int> metals = new Dictionary<string, int>();
            while ((input = Console.ReadLine()) != "stop")
            {
                string metal = input;
                int quantity = int.Parse(Console.ReadLine());

                if(metals.ContainsKey(metal))
                {
                    metals[metal] += quantity;
                }
                else
                {
                    metals.Add(metal, quantity);
                }
            }

            foreach(KeyValuePair<string, int> entry in metals)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }
    }
}
