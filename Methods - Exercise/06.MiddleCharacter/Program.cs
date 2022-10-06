using System;

namespace _06.MiddleCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(FindMiddle(input));

        }

        static string FindMiddle(string input)
        {
            if (input.Length % 2 != 0)
            {
                return input[input.Length / 2].ToString();
            }
            else
            {
                return input[input.Length / 2 -1].ToString() + input[input.Length / 2 ].ToString();
            }
        }
    }
}
