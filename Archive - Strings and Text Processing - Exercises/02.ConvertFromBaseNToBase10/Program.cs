using System;
using System.Numerics;
using System.Text;
namespace _02.ConvertFromBaseNToBase10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();
            int baseToConvertFrom = int.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);
            BigInteger result = 0;
            for (int i = 0; i < number.ToString().Length; i++)
            {
                int num = int.Parse(number.ToString()[i].ToString());
                int pow = number.ToString().Length -1 - i;
                BigInteger thisResult = 1;
                //result += (BigInteger)num * (BigInteger)Math.Pow(baseToConvertFrom, pow);
                for(int j = 1; j <= pow; j++)
                {
                    thisResult *= baseToConvertFrom;
                }
                result += thisResult * num;
            }

            Console.WriteLine(result.ToString());
        }
    }
}
