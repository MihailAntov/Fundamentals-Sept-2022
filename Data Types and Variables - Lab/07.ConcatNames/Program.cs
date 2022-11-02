using System;

namespace _07.ConcatNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string delimiter = Console.ReadLine();

            Console.WriteLine(string.Concat(firstName,delimiter,secondName));
        }
    }
}
