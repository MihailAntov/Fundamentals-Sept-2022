using System;
using System.Text;
namespace _06.SumBigNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = ReverseString(Console.ReadLine());
            string b = ReverseString(Console.ReadLine());
            
            int remainder = 0;
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < Math.Max(a.Length, b.Length); i++)
            {
                int first = i < a.Length ? int.Parse(a[i].ToString()) : 0;
                int second = i < b.Length ? int.Parse(b[i].ToString()) : 0;
                int thisSum = first + second + remainder;
                str.Insert(0, (thisSum % 10).ToString());
                remainder = thisSum / 10;

            }
            if(remainder != 0)
            {
                str.Insert(0, remainder);
            }

            while (str[0] == '0')
            {
                str.Remove(0, 1);
            }

            Console.WriteLine(str.ToString());
        }

        static string ReverseString(string input)
        {
            StringBuilder str = new StringBuilder();

            foreach(char c in input)
            {
                str.Insert(0, c);
            }
            return str.ToString();
        }
    }
}
