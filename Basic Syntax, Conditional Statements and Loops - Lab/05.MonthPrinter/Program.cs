using System;

namespace _05.MonthPrinter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] months = new string[]
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };

            int n = int.Parse(Console.ReadLine());

            if(n < 1 || n > 12)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine(months[n-1]);
            }
        }
    }
}
