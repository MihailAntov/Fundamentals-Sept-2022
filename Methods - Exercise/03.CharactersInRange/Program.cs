using System;

namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            PrintRange(firstChar, secondChar);

        }

        static void PrintRange (char a, char b)
        {
            if ((int)a > (int)b )
            {
                PrintRange(b, a);
            }

            for (int i = (int)a + 1; i < (int)b; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
