using System;
using System.Text.RegularExpressions;
namespace _07.Hideout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string map = Console.ReadLine();
            while(true)
            {
                string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string hideoutMark = input[0];
                int count = int.Parse(input[1]);

                string pattern = $"(?<hideout>\\{hideoutMark}{{{count},}})";
                Match match = Regex.Match(map, pattern);
                if(match.Success)
                {
                    int index = match.Groups["hideout"].Index;
                    int length = match.Groups["hideout"].Length;
                    Console.WriteLine($"Hideout found at index {index} and it is with size {length}!");
                    break;
                }
                
            }
        }
    }
}
