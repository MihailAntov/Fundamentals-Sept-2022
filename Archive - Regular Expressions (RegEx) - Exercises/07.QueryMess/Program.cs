using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
namespace _07.QueryMess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            string pattern = @"(?<field>[^?&\n]+?)=(?<value>[^?&\n]+)";
            
            Regex regex = new Regex(pattern);

            List<Dictionary<string, List<string>>> results = new List<Dictionary<string, List<string>>>();

            while ((input = Console.ReadLine())!= "END")
            {
                Dictionary<string, List<string>> database = new Dictionary<string, List<string>>();
                input = input.Replace("+"," ");
                input = input.Replace("%20", " ");
                while(input.Contains("  "))
                {
                    input = input.Replace("  ", " ");
                }

                MatchCollection matches = regex.Matches(input);

                foreach(Match match in matches)
                {
                    string field = match.Groups["field"].Value.Trim();
                    string value = match.Groups["value"].Value.Trim();

                    if(!database.ContainsKey(field))
                    {
                        database.Add(field, new List<string>());
                    }

                    database[field].Add(value);
                }

                results.Add(database);
            }

            foreach(Dictionary<string, List<string>> database in results)
            {
                foreach(KeyValuePair<string, List<string>> entry in database)
                {
                    Console.Write($"{entry.Key}=[{string.Join(", ",entry.Value)}]");
                }
                Console.WriteLine();
            }
            

            
        }
    }
}
