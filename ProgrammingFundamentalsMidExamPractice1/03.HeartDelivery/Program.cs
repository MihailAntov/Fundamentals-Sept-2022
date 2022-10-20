using System;
using System.Linq;

namespace _2_03.HeartDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] houses = Console.ReadLine()
                .Split("@", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();

            string input;
            int currentCupidLocation = 0;

            while ((input = Console.ReadLine())!= "Love!")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int jumpLength = int.Parse(cmdArgs[1]);
                currentCupidLocation += jumpLength;
                if (currentCupidLocation >= houses.Length)
                {
                    currentCupidLocation = 0;
                }

                if (houses[currentCupidLocation] == 0)
                {
                    Console.WriteLine($"Place {currentCupidLocation} already had Valentine's day.");
                    continue;
                }

                houses[currentCupidLocation] -= 2;

                if (houses[currentCupidLocation] == 0)
                {
                    Console.WriteLine($"Place {currentCupidLocation} has Valentine's day.");
                    
                }


            }
            bool failed = false;
            int failedHouses = 0;
            Console.WriteLine($"Cupid's last position was {currentCupidLocation}.");
            foreach(int house in houses)
            {
                if (house > 0)
                {
                    failed = true;
                    failedHouses++;
                }
            }

            if (failed)
            {
                Console.WriteLine($"Cupid has failed {failedHouses} places.");
            }
            else
            {
                Console.WriteLine("Mission was successful.");
            }
        }
    }
}
