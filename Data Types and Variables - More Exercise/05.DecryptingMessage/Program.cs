using System;

namespace _05.DecryptingMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string result = string.Empty;

            for (int i = 0; i <n; i++)
            {
                char nextCharacter = char.Parse(Console.ReadLine());
                result += (char)((int)nextCharacter + (int)key);
            }
            Console.WriteLine(result);
        }
    }
}
