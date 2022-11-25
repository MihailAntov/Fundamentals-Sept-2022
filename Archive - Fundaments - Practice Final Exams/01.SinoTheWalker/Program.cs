using System;
using System.Globalization;

namespace _01.SinoTheWalker
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime start = DateTime.ParseExact(Console.ReadLine(),"HH:mm:ss",CultureInfo.InvariantCulture);
            int steps = int.Parse(Console.ReadLine()) % 86400;
            int seconds = int.Parse(Console.ReadLine()) % 86400;

            long totalSeconds = steps * seconds;

            DateTime arrival = start.AddSeconds(totalSeconds);

            Console.WriteLine($"Time Arrival: {arrival.Hour:d2}:{arrival.Minute:d2}:{arrival.Second:d2}");


        }
    }
}
