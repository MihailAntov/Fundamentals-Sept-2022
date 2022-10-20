using System;

namespace _01.SoftUniReception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstEmployeeRate = int.Parse(Console.ReadLine());
            int secondEmployeeRate = int.Parse(Console.ReadLine());
            int thirdEmployeeRate = int.Parse(Console.ReadLine());

            int students = int.Parse(Console.ReadLine());
            int hourCounter = 0;
            while (students > 0)
            {
                hourCounter++;
                if (hourCounter  %4 == 0)
                {
                    
                    continue;
                }
                students -= (firstEmployeeRate + secondEmployeeRate + thirdEmployeeRate);
                
            }

            Console.WriteLine($"Time needed: {hourCounter}h.");

        }
    }
}
