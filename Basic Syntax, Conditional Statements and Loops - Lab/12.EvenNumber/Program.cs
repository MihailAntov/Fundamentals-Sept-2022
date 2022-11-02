using System;

namespace _12.EvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input; 

            while(int.Parse(input = Console.ReadLine())%2 != 0)
            {
                Console.WriteLine("Please write an even number.");
            }

            Console.WriteLine($"The number is: {Math.Abs(int.Parse(input))}");
        }
    }
}
