using System;
using System.Collections.Generic;
using System.Linq;
namespace _03.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string key = Console.ReadLine();
                string value = Console.ReadLine();

                if (synonyms.ContainsKey(key))
                {
                    synonyms[key].Add(value);
                }
                else
                {
                    synonyms.Add(key, new List<string> { value });
                }
            }

            foreach(KeyValuePair<string, List<string>> entry in synonyms)
            {
                Console.WriteLine($"{entry.Key} - {String.Join(", ", entry.Value)}");
            }
        }
    }
}
