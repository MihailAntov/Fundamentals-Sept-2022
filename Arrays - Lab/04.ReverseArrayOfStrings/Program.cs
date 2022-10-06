using System;
using System.Linq;

namespace _04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(' ');
            
            foreach(string s in strings.Reverse())
            {
                Console.Write(s + " ");
            }
        }
    }
}
