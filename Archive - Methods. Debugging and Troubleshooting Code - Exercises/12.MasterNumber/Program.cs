using System;
using System.Linq;

namespace _12.MasterNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if(IsMaster(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool IsMaster(int number)
        {
            if(!IsSymmetric(number) || !IsSumDivisbleBySeven(number) || !HasAtLeastOneEvenDigit(number))
            {
                return false;
            }
            return true;
        }

        public static bool IsSymmetric(int number)
        {
            string numberAsDigit = number.ToString();

            for (int i = 0; i < numberAsDigit.Length/2; i++)
            {
                if (numberAsDigit[i] != numberAsDigit[numberAsDigit.Length-1-i])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsSumDivisbleBySeven(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            if(sum %7 != 0)
            {
                return false;
            }
            return true;
            
        }

        public static bool HasAtLeastOneEvenDigit(int number)
        {
            string numberAsString = number.ToString();
            for(int i = 0; i < numberAsString.Length-1;i++)
            {
                if (int.Parse(numberAsString[i].ToString()) % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
