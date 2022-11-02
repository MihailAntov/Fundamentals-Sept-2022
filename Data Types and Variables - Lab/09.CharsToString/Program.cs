using System;

namespace _09.CharsToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = new char[3];
            chars[0] = char.Parse(Console.ReadLine());
            chars[1] = char.Parse(Console.ReadLine());
            chars[2] = char.Parse(Console.ReadLine());

            Console.WriteLine(String.Join("",chars));
        }
    }
}
