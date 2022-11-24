using System;
using System.Text.RegularExpressions;
using System.Linq;
namespace _05.KeyReplacer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string keyString = Console.ReadLine();
            string textString = Console.ReadLine();
            string keyPattern = @"^(?<start>.*?)[\|\,\<\\].*[\|\,\<\\](?<end>.*)$";
            Regex keyRegex = new Regex(keyPattern);
            string start = string.Empty;
            string end = string.Empty;
            Match match = keyRegex.Match(keyString);
            if(match.Success)
            {
                start = match.Groups["start"].Value;
                end = match.Groups["end"].Value;

                string textPattern = $@"{start}(?<word>.*?){end}";
                Regex textRegex = new Regex(textPattern);
                MatchCollection words = textRegex.Matches(textString);

                if(words.Count == 0)
                {
                    Console.WriteLine("Empty result");
                    return;
                }
                else
                {
                    Console.WriteLine(String.Join("",words
                        .Select(n => n.Groups["word"].Value)
                        .ToArray()));
                }
            }
            else
            {
                Console.WriteLine("Empty result");
            }

            


        }
    }
}
