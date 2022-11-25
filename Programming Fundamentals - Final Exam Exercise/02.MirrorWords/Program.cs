using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
namespace _02.MirrorWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(@|#)(?<word1>[A-Za-z]{3,})\1\1(?<word2>[A-Za-z]{3,})\1";

            Regex regex = new Regex(pattern);
            List<String[]> mirrorPairs = new List<string[]>();
            MatchCollection matches = regex.Matches(input);

            foreach(Match match in matches)
            {
                string word1 = match.Groups["word1"].Value;
                string word2 = match.Groups["word2"].Value;
                string word2reversed = string.Join("",word2.ToCharArray().Reverse());
                if(word1 == word2reversed)
                {
                    mirrorPairs.Add(new string[] { word1, word2 });
                }
            }

            if(matches.Count  == 0 )
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
                if(mirrorPairs.Count == 0)
                {
                    Console.WriteLine("No mirror words!");
                    
                }
                else
                {
                    Console.WriteLine("The mirror words are:");
                    Console.WriteLine(String.Join(", ",mirrorPairs
                        .Select(n => $"{n[0]} <=> {n[1]}")));
                }
            }


        }
    }
}
