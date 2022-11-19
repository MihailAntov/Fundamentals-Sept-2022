using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace _04.PunctuationFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "sample_text.txt";
            string path = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            string text = File.ReadAllText(path);

            List<char> result = new List<char>();
            char[] punctuation = new char[] { '.', ',', '!', '?', ':' };
            foreach(char c in text)
            {
                if(punctuation.Contains(c))
                {
                    result.Add(c);
                }
            }

            Console.WriteLine(String.Join(", ",result));
        }
    }
}
