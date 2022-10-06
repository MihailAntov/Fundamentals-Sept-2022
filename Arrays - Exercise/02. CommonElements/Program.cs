using System;
using System.Linq;
namespace _02._CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');

            string[] intersection = secondArray.Intersect(firstArray).ToArray();
            foreach (string s in intersection)
            {
                Console.Write(s + " ");
            }
        }
    }
}
