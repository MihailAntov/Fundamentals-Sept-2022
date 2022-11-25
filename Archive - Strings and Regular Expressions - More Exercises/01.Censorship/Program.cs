using System;

namespace _01.Censorship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string sentence = Console.ReadLine();

            sentence = sentence.Replace(word, new String('*', word.Length));
            Console.WriteLine(sentence);
        }
    }
}
