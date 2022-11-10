using System;
using System.Linq;
using System.Collections.Generic;

namespace _09.LegendaryFarming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> matsTotal = new Dictionary<string, int>
            {
                {"motes", 0 },
                {"fragments", 0 },
                {"shards", 0 }
            };


            while (matsTotal["motes"] < 250 && matsTotal["fragments"] < 250 && matsTotal["shards"] < 250)
            {
                string[] inputArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string[] materials = new string[inputArgs.Length / 2];
                int[] quantities = new int[inputArgs.Length / 2];

                for (int i = 0; i < inputArgs.Length / 2; i++)
                {

                    quantities[i] = int.Parse(inputArgs[2 * i]);
                    materials[i] = inputArgs[2 * i + 1].ToLower();
                }

                for (int i = 0; i < materials.Length; i++)
                {
                    if (!matsTotal.ContainsKey(materials[i]))
                    {
                        matsTotal.Add(materials[i], 0);
                    }
                    matsTotal[materials[i]] += quantities[i];

                   if(matsTotal["motes"] >= 250 || matsTotal["fragments"] >= 250 || matsTotal["shards"] >= 250)
                    {
                        break;
                    }


                }
            }

            if (matsTotal["motes"]>=250)
            {
                matsTotal["motes"] -= 250;
                Console.WriteLine("Dragonwrath obtained!");
            }

            if (matsTotal["fragments"] >= 250)
            {
                matsTotal["fragments"] -= 250;
                Console.WriteLine("Valanyr obtained!");
            }
            if (matsTotal["shards"] >= 250)
            {
                matsTotal["shards"] -= 250;
                Console.WriteLine("Shadowmourne obtained!");
            }

            foreach (KeyValuePair<string, int> mat in matsTotal.Where(n=>
            n.Key == "motes" || n.Key == "shards" || n.Key == "fragments").OrderByDescending(n=>n.Value).ThenBy(n=>n.Key))
            {

                Console.WriteLine($"{mat.Key}: {mat.Value}");
            }

            foreach (KeyValuePair<string, int> mat in matsTotal.Where(n =>
            n.Key != "motes" && n.Key != "shards" && n.Key != "fragments").OrderBy(n => n.Key))
            {

                Console.WriteLine($"{mat.Key}: {mat.Value}");
            }


        }
    }
}
