using System;
using System.Text.RegularExpressions;
using System.Linq;
namespace _02.MessageDecrypter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            string pattern = @"^(\$|\%)(?<tag>[A-Z][a-z]{2,})\1: \[(?<first>\d+)\]\|\[(?<second>\d+)\]\|\[(?<third>\d+)\]\|$";
            
            Regex regex = new Regex(pattern);

            for(int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = regex.Match(input);
                if (!match.Success)
                {
                    Console.WriteLine("Valid message not found!");
                    continue;   
                }


                int firstValue = int.Parse(match.Groups["first"].Value);
                int secondValue = int.Parse(match.Groups["second"].Value);
                int thirdValue = int.Parse(match.Groups["third"].Value);

                string result = $"{match.Groups["tag"].Value}: {(char)firstValue}{(char)secondValue}{(char)thirdValue}";
                Console.WriteLine(result);


            }
            
        }
    }
}
