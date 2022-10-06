using System;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            Random randomNum = new Random();

            for (int i = 0; i < words.Length-1; i++)
            {
                int randomNumNext = randomNum.Next(words.Length-1);
                string buffer = words[randomNumNext];
                words[randomNumNext] = words[i];
                words[i] = buffer;
            }
            
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            
        }
    }
}
