using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.MorseCodeTranslator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" | ", StringSplitOptions.RemoveEmptyEntries);

            string result = string.Empty;
            Dictionary<string, char> morseCode = new Dictionary<string, char>
            {
                {".-", 'a' },
                {"-...", 'b' },
                {"-.-.", 'c' },
                {"-..", 'd' },
                {".", 'e' },
                {"..-.", 'f' },
                {"--.", 'g' },
                {"....", 'h' },
                {"..", 'i' },
                {".---", 'j' },
                {"-.-", 'k' },
                {".-..", 'l' },
                {"--", 'm' },
                {"-.", 'n' },
                {"---", 'o' },
                {".--.", 'p' },
                {"--.-", 'q' },
                {".-.", 'r' },
                {"...", 's' },
                {"-", 't' },
                {"..-", 'u' },
                {"...-", 'v' },
                {".--", 'w' },
                {"-..-", 'x' },
                {"-.--", 'y' },
                {"--..", 'z' },

            };


            foreach(string word in input)
            {
                string[] letters = word.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach(string letter in letters)
                {
                    result += morseCode[letter];
                }
                result += ' ';
            }

            Console.WriteLine(result.ToUpper());
        }
    }
}
