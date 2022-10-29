using System;

namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split("\\");
            string[] fileAndExtension = input[input.Length - 1]
                .Split(".");
            string file = fileAndExtension[0];
            string extension = fileAndExtension[1];

            Console.WriteLine($"File name: {file}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
