using System;
using System.Linq;
using System.Numerics;
using System.Text;
namespace _01.ConvertFromBase10ToBaseN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ')
                .ToArray();

            int baseToConvertTo = int.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);
            StringBuilder remainders = new StringBuilder();
            while (number >= baseToConvertTo)
            {
                remainders.Append(number%baseToConvertTo);
                number = number / baseToConvertTo;
            }
            remainders.Append(number);

            char[] chars = new char[remainders.Length];
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = remainders[remainders.Length - 1 - i];
            }
            string result = string.Join(string.Empty, chars);
            

            Console.WriteLine(result);
        }
    }
}
