using System;

namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Repeat(input, n));
        }

        static string Repeat(string s, int n)
        {
            string result = string.Empty;
            for (int i = 0; i < n; i++)
            {
                result += s;
            }
            return result;
        }
    }
}
