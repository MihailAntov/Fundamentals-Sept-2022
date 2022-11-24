using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02.FancyBarcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"^@#+[A-Z](?<chars>[a-zA-Z\d]{4,})[A-Z]@#+$";
            Regex regex = new Regex(pattern);
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = regex.Match(input);
                if(match.Success)
                {
                    string chars = match.Groups["chars"].Value;
                    string digits = string.Join(string.Empty, chars
                        .Where(n => char.IsDigit(n))
                        .ToArray());

                        
                        
                        
                    if(digits.Length == 0)
                    {
                        digits = "00";
                    }
                        

                    Console.WriteLine($"Product group: {digits}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }


            }
        }
    }
}
