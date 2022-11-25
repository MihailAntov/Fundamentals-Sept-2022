using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
namespace _03.SantasSecretHelper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());

            string input;
            List<string> goodKids = new List<string>();
            string pattern = @"@(?<name>[a-zA-Z]+)[^\@\-\!\:\>]+!(?<behaviour>[G|N]{1})!";
            Regex regex = new Regex(pattern);
            while((input = Console.ReadLine())!= "end")
            {
                input = string.Join("",input.ToCharArray().Select(n => (char)((int)n - key)).ToArray());
                Match match = regex.Match(input);
                if(match.Success)
                {
                    if (match.Groups["behaviour"].Value == "G")
                    {
                        goodKids.Add(match.Groups["name"].Value);
                    }
                }
            }

            Console.WriteLine(String.Join(Environment.NewLine, goodKids));

            
        }
    }
}
