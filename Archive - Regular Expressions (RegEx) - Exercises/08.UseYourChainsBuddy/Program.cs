using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _08.UseYourChainsBuddy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"<p>(?<text>.*?)<\/p>";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();
            MatchCollection matches = regex.Matches(input);

            string replacementPattern = @"[^\da-z]+";
            string replacement = " ";

            
            
            List<string> results = new List<string>();
            foreach(Match match in matches)
            {
                string text = match.Groups["text"].Value;
                text = Decrypt(text);
                text = Regex.Replace(text, replacementPattern, replacement);
                results.Add(text);
            }

            Console.WriteLine(String.Join("",results));
            
                
        }

        public static string Decrypt(string text)
        {
            StringBuilder str = new StringBuilder();
            foreach(char c in text)
            {
                if((int)c >= 97 && (int)c <= 109)
                {
                    str.Append((char)((int)c + 13));
                }
                else if ((int)c >= 110 && (int)c <= 122)
                {
                    str.Append((char)((int)c - 13));
                }
                else
                {
                    str.Append(c);
                }
            }

            return str.ToString();


        }

        
    }
}
