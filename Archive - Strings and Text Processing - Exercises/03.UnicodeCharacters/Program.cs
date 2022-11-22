using System;
using System.Globalization;
using System.Text;
namespace _03.UnicodeCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] unicodeChars = new string[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                unicodeChars[i] = $"\\u{(int)input[i]:x4}";
            }

            Console.WriteLine(String.Join("",unicodeChars));
        }
    }
}
