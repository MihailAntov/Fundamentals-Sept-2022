using System;
using System.Collections.Generic;
using System.Linq;
namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i} -> {IsSpecial(i)}");
            }
        }
        
        public static List<int> GetDigits(int number)
        {
            List<int> digits = new List<int>();
            while(number > 0)
            {
                digits.Add(number % 10);
                number /= 10;
            }
            digits.Add(number % 10);
            return digits;
        }

        public static bool IsSpecial(int n)
        {
            if(GetDigits(n).Sum() == 5 || GetDigits(n).Sum() == 7 || GetDigits(n).Sum() == 11)
            {
                return true;
            }
            return false;
                    
        }
    }
}
