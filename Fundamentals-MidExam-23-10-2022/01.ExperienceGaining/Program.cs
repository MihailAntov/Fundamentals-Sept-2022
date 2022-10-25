using System;

namespace _01.ExperienceGaining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal xpNeeded = decimal.Parse(Console.ReadLine());
            int battles = int.Parse(Console.ReadLine());
            decimal totalXp = 0;
            for (int i = 1; i <= battles; i++)
            {
                decimal xpEarned = decimal.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    xpEarned *= 1.15M;
                }

                if (i % 5 == 0)
                {
                    xpEarned *= 0.9M;
                }

                if (i % 15 == 0)
                {
                    xpEarned *= 1.05M;
                }

                totalXp += xpEarned;
                if (totalXp >= xpNeeded)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {i} battles.");
                    return;
                }

            }

            Console.WriteLine($"Player was not able to collect the needed experience, {xpNeeded-totalXp:f2} more needed.");
        }
    }
}
