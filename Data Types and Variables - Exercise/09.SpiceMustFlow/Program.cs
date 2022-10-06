using System;

namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long yieldForTheDay = int.Parse(Console.ReadLine());
            long totalYield = 0;
            int days = 0;

            while (yieldForTheDay >= 100)
            {
                totalYield += yieldForTheDay;
                if(totalYield >= 26)
                {
                    totalYield -= 26;
                }
                else
                {
                    totalYield = 0;
                }

                yieldForTheDay -= 10;
                days++;
            }
            if (totalYield >= 26)
            {
                totalYield -= 26;
            }
            else
            {
                totalYield = 0;
            }
            
            Console.WriteLine(days);
            Console.WriteLine(totalYield);
            
        }
    }
}
