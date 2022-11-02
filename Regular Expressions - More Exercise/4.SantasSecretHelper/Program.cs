using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _4.SantasSecretHelper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            string input;
            string filter = @"(?<=@)(?<name>[A-Za-z]+)[^@\-!:>]*!(?<behavior>G)!";
            List<Kid> kids = new List<Kid>();
            
            while ((input = Console.ReadLine())!= "end")
            {
                StringBuilder strBuilder = new StringBuilder();
                foreach(char c in input)
                {
                    strBuilder.Append((char)((int)c - key));
                }


                string decodedString = strBuilder.ToString();

                Match match = Regex.Match(decodedString, filter);
                if(match.Success)
                {
                    kids.Add(new Kid(match.Groups["name"].Value, match.Groups["behavior"].Value));
                }
            }

            foreach(Kid kid in kids.Where(n=>n.Behavior == "G"))
            {
                Console.WriteLine(kid.Name);
            }

            
        }
    }

    public class Kid
    {
        public Kid(string name, string behavior)
        {
            Name = name;
            Behavior = behavior;
        }

        public string Name { get; set; }
        public string Behavior { get; set; }
    }
}
