using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.EncryptSortAndPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string vowels = "aeoui";
            string[] strings = new string[n];
            for (int i = 0; i < n; i++)
            {
                strings[i] = Console.ReadLine();
            }

            int[] codes = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                char[] chars = strings[i].ToCharArray();
                int[] digits = new int[chars.Length];
                for (int j = 0; j < chars.Length; j++)
                {
                    if (vowels.Contains(chars[j].ToString().ToLower()))
                    {
                        digits[j] = (int)chars[j] * chars.Length;
                    }
                    else

                    {
                        digits[j] = (int)chars[j] / chars.Length;
                    }
                }
                int sum = digits.Sum();
                codes[i] = sum;
            }
            Array.Sort(codes);
            foreach(int code in codes)
            {
                Console.WriteLine(code);
            }
        }
    }
}
