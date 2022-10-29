using System;

namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = string.Empty;

            foreach(char c in input)
            {
                result += (char)((int)c + 3);
            }

            Console.WriteLine(result);
        }
    }
}
