using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _01.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string input = Console.ReadLine();
                

            MatchCollection matchedNames = Regex.Matches(input, regex);
            Console.WriteLine(String.Join(" ", matchedNames.Select(n=>n.Value)));
        }
    }
}
