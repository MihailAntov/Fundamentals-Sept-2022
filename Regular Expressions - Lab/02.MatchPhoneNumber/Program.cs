using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @"\+359([- ])2\1[0-9]{3}\1[0-9]{4}\b";
            

            MatchCollection sofiaPhones = Regex.Matches(input, regex);

            Console.WriteLine(String.Join(", ",sofiaPhones.Select(n=>n.Value)));
        }
    }
}
