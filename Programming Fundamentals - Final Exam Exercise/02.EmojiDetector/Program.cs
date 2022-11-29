using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Numerics;
namespace _02.EmojiDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string emojiPattern = @"(\:\:|\*\*)[A-Z][a-z]{2,}\1";
            string coolnessPattern = @"\d";  
            int[] numbers = Regex.Matches(input, coolnessPattern)
                .Select(n => int.Parse(n.Value)).ToArray();
            BigInteger coolnessThreshold = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                coolnessThreshold *= numbers[i];
            }
            
                

            MatchCollection matches = Regex.Matches(input,emojiPattern);

            Console.WriteLine($"Cool threshold: {coolnessThreshold}");
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");
            foreach(Match match in matches
                .Where(n=>IsCool(n.Value,coolnessThreshold)))
            {
                Console.WriteLine(match.Value);
            }
        }

        public static bool IsCool(string input, BigInteger threshold)
        {
            int sum = input.Substring(2,input.Length-4).Select(n => (int)n).Sum();
            return sum >= threshold ? true : false;

        }
    }
}
