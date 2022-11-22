using System;
using System.Text;

namespace _01.ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder str = new StringBuilder();

            foreach(char c in input)
            {
                str.Insert(0, c);
            }

            Console.WriteLine(str);
        }
    }
}
