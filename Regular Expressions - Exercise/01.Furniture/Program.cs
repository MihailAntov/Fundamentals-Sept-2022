using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
namespace _01.Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string regex = @">>(?<name>[A-z]+)<<(?<price>[0-9.]+)!(?<quantity>\d+)";
            string input;
            decimal total = 0;
            List<Match> matches = new List<Match>();
            while ((input = Console.ReadLine())!= "Purchase")
            {
                Match item = Regex.Match(input, regex);
                if(item.Success)
                {
                    matches.Add(item);
                }
            }
            Console.WriteLine("Bought furniture:");
            foreach(Match item in matches)
            {
                string name = item.Groups["name"].Value;
                decimal price = decimal.Parse(item.Groups["price"].Value);
                int quantity = int.Parse(item.Groups["quantity"].Value);


                Console.WriteLine(name);
                total += price * quantity;
            }

            
            
            
            Console.WriteLine($"Total money spend: {total:f2}");
        }
    }
}
