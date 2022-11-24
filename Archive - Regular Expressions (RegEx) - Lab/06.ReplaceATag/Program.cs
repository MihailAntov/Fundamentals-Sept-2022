using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace _06.ReplaceATag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<opener><a(?<href>.*)>).*(?<closer></a>)";

            Regex regex = new Regex(pattern);
            
            string input;
            List<string> results = new List<string>();
            while((input = Console.ReadLine())!= "end")
            {
                Match match = regex.Match(input);
                if(!match.Success)
                {
                    results.Add(input);
                    continue;
                }
                string href = match.Groups["href"].Value;
                string opener = match.Groups["opener"].Value;
                string closer = match.Groups["closer"].Value;
                input = input.Replace(opener, $"[URL{href}]");
                input = input.Replace(closer, "[/URL]");

                results.Add(input);

            }

            Console.WriteLine(String.Join(Environment.NewLine,results));
        }
    }
}
