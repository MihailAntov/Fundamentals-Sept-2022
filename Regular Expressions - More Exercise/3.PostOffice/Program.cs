using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
namespace _3.PostOffice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split("|");

            string capitalFilter = @"([$#%&\*])(?<capitals>[A-Z]+)\1";
            string codeFilter = @"(?<ascii>\d\d):(?<length>\d\d)";

            

            string capitals = String.Join("", Regex.Matches(input[0], capitalFilter)
                .Select(n => n.Groups["capitals"].Value)
                .ToArray());

            List<Word> words = new List<Word>();
            MatchCollection codeMatches = Regex.Matches(input[1], codeFilter);

            for (int i = 0; i < capitals.Length; i++)
            {
                Match match = Regex.Matches(input[1], codeFilter)
                    .FirstOrDefault(n => (char)int.Parse(n.Groups["ascii"].Value) == capitals[i]);

                if(match.Success)
                {   
                    words.Add(new Word((char)int.Parse(match.Groups["ascii"].Value),
                        int.Parse(match.Groups["length"].Value)));
                }
            }



            foreach (Word word in words)
            {
                Match extractedWord = Regex.Match(input[2], word.Regex);
                if(extractedWord.Success)
                {
                    Console.WriteLine(extractedWord.Groups["word"].Value);
                }
            }
        }
    }

    public class Word
    {
        public Word(char capitalLetter, int length)
        {
            this.CapitalLetter = capitalLetter;
            this.Length = length;
            this.Regex = $@"(^|\s)(?<word>{capitalLetter}\S{{{length}}})(\s|$)";
        }
        public char CapitalLetter { get; set; }
        public int Length { get; set; }
        public string Regex { get; set; }
    }
}
