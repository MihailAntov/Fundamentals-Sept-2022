using System;
using System.Text;
namespace _06.SumBigNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            
            if (b == 0)
            {
                Console.WriteLine("0");
                return;
            }

            if(b == 1)
            {
                Console.WriteLine(a);
                return;
            }

            int remainder = 0;
            StringBuilder str = new StringBuilder();
            for (int i = a.Length-1; i >= 0; i--)
            {
                int currentDigitOfA = int.Parse(a[i].ToString());
                str.Insert(0, (currentDigitOfA * b + remainder) % 10);
                remainder = (currentDigitOfA * b + remainder) / 10;

            }

            if (remainder != 0)
            {
                str.Insert(0, remainder);
            }

            while (str[0] == '0')
            {
                str.Remove(0, 1);
            }

            Console.WriteLine(str.ToString());
        }

        
    }
}
