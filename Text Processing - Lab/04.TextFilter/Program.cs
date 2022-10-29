using System;
using System.Linq;

namespace _04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine()
                .Split(", ");

            string text = Console.ReadLine();

            foreach(string word in bannedWords)
            {
                string replacement = string.Empty;

                for (int i = 0; i < word.Length; i++)
                {
                    replacement += "*";
                }
                text = text.Replace(word, replacement);
            }
            Console.WriteLine(text);
        }
    }
}
