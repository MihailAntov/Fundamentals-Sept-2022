using System;

namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string toBeRemoved = Console.ReadLine();
            string source = Console.ReadLine();

            while (source.Contains(toBeRemoved))
            {
                source = source.Replace(toBeRemoved, "");
            }

            Console.WriteLine(source);
        }
    }
}
