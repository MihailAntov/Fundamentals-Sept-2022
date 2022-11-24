using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02.ExtractSentencesByKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string targetWord = Console.ReadLine();
            string input = Console.ReadLine();

            string sentencePattern = @"(^|\s)(?<sentence>.*?)[\?\.\!]";
            Regex sentenceRegex = new Regex(sentencePattern);

            string wordPattern = $@"\b{targetWord}\b";
            Regex wordRegex = new Regex(wordPattern);

            MatchCollection sentences = sentenceRegex.Matches(input);

            foreach (Match sentence in sentences.Where(n=>wordRegex.IsMatch(n.ToString())))
            {
                Console.WriteLine(sentence.Groups["sentence"].Value);
                
            }
        }
    }
}
