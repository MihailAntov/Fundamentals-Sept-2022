using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace _07.TakeSkipRope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> digits = input
                .Where(n => char.IsDigit(n))
                .Select(n => int.Parse(n.ToString()))
                .ToList();
            int[] take = new int[digits.Count / 2];
            int[] skip = new int[digits.Count / 2];

            for (int i = 0; i < digits.Count; i++)
            {
                if (i % 2 == 0)
                {
                    take[i/2] = digits[i];
                }
                else
                {
                    skip[i / 2] = digits[i];
                }
            }

            List<char> symbols = input
                .Where(n => !char.IsDigit(n))
                .ToList();
            
            StringBuilder str = new StringBuilder();
            int runningSkipCount = 0;
            for (int i = 0; i < take.Length; i++)
            {
                str.Append(String.Join("",symbols.Skip(runningSkipCount).Take(take[i])));
                runningSkipCount += skip[i] + take[i];
            }
            
            Console.WriteLine(str.ToString());
        }
    }
}
