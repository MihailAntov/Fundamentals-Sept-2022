using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] strings = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(n=>n.ToLower().ToString()).ToArray();
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            foreach(string s in strings)
            {
                if(dictionary.ContainsKey(s))
                {
                    dictionary[s]++;
                }
                else
                {
                    dictionary.Add(s, 1);
                }
            }

            foreach(KeyValuePair<string, int> word in dictionary.Where(n=>n.Value % 2 != 0))
            {
                Console.Write(word.Key + " ");
            }
        }
    }
}
