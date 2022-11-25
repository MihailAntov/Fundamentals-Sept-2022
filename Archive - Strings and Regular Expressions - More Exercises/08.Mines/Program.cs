using System;
using System.Linq;
using System.Text.RegularExpressions;


namespace _08.Mines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputAsText = Console.ReadLine();
            char[] input = inputAsText.ToCharArray();
            string pattern = @"<.{2}>";

            MatchCollection matches = Regex.Matches(inputAsText, pattern);
            foreach(Match match in matches)
            {
                int index = match.Index;
                char firstChar = input[index + 1];
                char secondChar = input[index + 2];

                int power = Math.Abs((int)firstChar - (int)secondChar);
                int start = Math.Max(0, index - power);
                int end = Math.Min(input.Length - 1, index + 3 + power);

                for (int i = start; i <= end; i++)
                {
                    input[i] = '_';
                }
            }
            

            Console.WriteLine(String.Join("",input));
             
        }
    }
}
