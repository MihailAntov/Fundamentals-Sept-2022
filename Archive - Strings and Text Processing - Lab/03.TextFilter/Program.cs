using System;

namespace _03.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (string word in words)
            {
                text = text.Replace(word, new String('*', word.Length));
            }
            Console.WriteLine(text);
            
        }

        
    }
}
