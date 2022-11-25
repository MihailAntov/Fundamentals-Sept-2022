using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
namespace _06.EmailStatistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"^(?<user>[A-Za-z]{5,})@(?<domain>[a-z]{3,}\.(com|org|bg))$";
            Dictionary<string, List<string>> domains = new Dictionary<string, List<string>>();
            Regex regex = new Regex(pattern);
            
            for (int i = 0; i < n; i++)
            {
                Match match = regex.Match(Console.ReadLine());
                if(match.Success)
                {
                    string userName = match.Groups["user"].Value;
                    string domain = match.Groups["domain"].Value;

                    if(!domains.ContainsKey(domain))
                    {
                        domains.Add(domain, new List<string>());
                    }

                    if(!domains[domain].Contains(userName))
                    {
                        domains[domain].Add(userName);
                    }
                    
                }
            }

           

            foreach(KeyValuePair<string, List<string>> domain in domains
                .OrderByDescending(n=>n.Value.Count()))
            {
                

                Console.WriteLine($"{domain.Key}:");
                foreach (string userName in domain.Value)
                {
                    Console.WriteLine($"### {userName}");
                }
            }
        }
    }
}
