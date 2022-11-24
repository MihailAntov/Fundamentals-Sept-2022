using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace _03.CameraView
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();

            int skip = integers[0];
            int take = integers[1];

            string pattern = @"(\|\<(?<camera>.*?)(?=(\|\<)|$))";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection cameras = regex.Matches(input);
            List<string> results = new List<string>();
            foreach(Match cam in cameras)
            {
                string content = String.Join("", cam.Groups["camera"].Value.Skip(skip).Take(take));
                results.Add(content);
            }
            Console.WriteLine(String.Join(", ",results));
        }
    }
}
