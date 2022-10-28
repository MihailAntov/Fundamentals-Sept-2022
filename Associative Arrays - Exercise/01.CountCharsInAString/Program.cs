using System;
using System.Collections.Generic;
using System.Linq;
namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> chars = new Dictionary<char, int>();
            foreach(char c in input)
            {
                if(c ==' ')
                {
                    continue;
                }
                
                if(chars.ContainsKey(c))
                {
                    chars[c]++;
                }
                else
                {
                    chars.Add(c, 1);
                }
            }

            foreach(KeyValuePair<char, int> entry in chars)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }
    }
}
