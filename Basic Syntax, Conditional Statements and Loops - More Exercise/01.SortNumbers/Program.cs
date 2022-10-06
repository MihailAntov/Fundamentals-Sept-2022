using System;
using System.Collections.Generic;

namespace _01.SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(int.Parse(Console.ReadLine()));
            numbers.Add(int.Parse(Console.ReadLine()));
            numbers.Add(int.Parse(Console.ReadLine()));
            numbers.Sort((a, b) => b.CompareTo(a));
            
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
