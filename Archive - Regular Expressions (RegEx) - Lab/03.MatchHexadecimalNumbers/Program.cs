using System;
using System.Text.RegularExpressions;
using System.Linq;
namespace _03.MatchHexadecimalNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b(0x)?[0-9A-F]+\b";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);
            Console.WriteLine(String.Join(" ",matches));
        }
    }
}
