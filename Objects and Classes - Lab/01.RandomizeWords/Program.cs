using System;
using System.Linq;
namespace _01.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Random rnd = new Random();

            string[] stringArr = input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < stringArr.Length; i++)
            {
                string buffer = stringArr[i];
                int otherIndex = rnd.Next(0, stringArr.Length);
                stringArr[i] = stringArr[otherIndex];
                stringArr[otherIndex] = buffer;
                
            }

            foreach(string s in stringArr)
            {
                Console.WriteLine(s);
            }
        }
    }
}
