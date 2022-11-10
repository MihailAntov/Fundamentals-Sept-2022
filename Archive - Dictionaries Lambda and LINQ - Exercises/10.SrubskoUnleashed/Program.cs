using System;
using System.Collections.Generic;
using System.Linq;
namespace _10.SrubskoUnleashed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, Dictionary<string, decimal>> locations = new Dictionary<string, Dictionary<string, decimal>>();

            while((input = Console.ReadLine()) != "End")
            {

                //string singer = input.Substring(0, input.IndexOf("@") - 1);
                //string[] inputArgs = input.Substring(input.IndexOf("@") + 1).Split(" ", StringSplitOptions.RemoveEmptyEntries);
                //decimal price = decimal.Parse(inputArgs[inputArgs.Length - 2]);
                //int count = int.Parse(inputArgs[inputArgs.Length - 1]);
                //string location = input.Substring(input.IndexOf("@") + 1,
                //     input.IndexOf(price.ToString()) - input.IndexOf("@") - 2);

                List<string> inputArgs = input.Split(" ")
                    .ToList();

                int indexOfLocation = -1;

                for (int i = 0; i < inputArgs.Count; i++)
                {
                    if (inputArgs[i][0] == '@')
                    {
                        indexOfLocation = i;
                    }
                }

                if(inputArgs.Count < 4)
                {
                    continue;
                }

                if(indexOfLocation == -1)
                {
                    continue;
                    
                }

                bool areNumbersValid = true;
                foreach(char c in inputArgs[inputArgs.Count-2])
                {
                    if (!char.IsDigit(c))
                    {
                        areNumbersValid = false;
                    }
                }

                foreach (char c in inputArgs[inputArgs.Count - 1])
                {
                    if (!char.IsDigit(c))
                    {
                        areNumbersValid = false;
                    }
                }

                if(!areNumbersValid)
                {
                    continue;
                }


                if (indexOfLocation >= inputArgs.Count - 2 || indexOfLocation < 1)
                {
                    continue;
                }

                string singer = string.Join(" ", inputArgs.Where(n=>inputArgs.IndexOf(n) < indexOfLocation));
                
                inputArgs[indexOfLocation] = inputArgs[indexOfLocation].Substring(1);

                string location = string.Join(" ", inputArgs
                    .Where(n=>inputArgs.IndexOf(n) >= indexOfLocation &&
                    inputArgs.IndexOf(n) < inputArgs.Count-2));
                decimal price = decimal.Parse(inputArgs[inputArgs.Count - 2]);
                int quantity = int.Parse(inputArgs[inputArgs.Count - 1]);

                if(!locations.ContainsKey(location))
                {
                    locations.Add(location, new Dictionary<string, decimal>());
                }

                if (!locations[location].ContainsKey(singer))
                {
                    locations[location].Add(singer, 0);
                }

                locations[location][singer] += price * quantity;

            }

            foreach(KeyValuePair<string, Dictionary<string, decimal>> location in locations)
            {
                Console.WriteLine(location.Key);

                foreach(KeyValuePair<string, decimal> singer in location.Value.OrderByDescending(n=>n.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
