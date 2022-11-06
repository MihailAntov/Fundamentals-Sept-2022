using System;

namespace _04.NumbersInReversedOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseDigits(Console.ReadLine()));
        }

        public static string ReverseDigits(string number)
        {
            string result = string.Empty;
            for(int i = number.Length-1; i >=0; i--)
            {
                result+= number[i];
            }

            return result;
        }
    }
}
