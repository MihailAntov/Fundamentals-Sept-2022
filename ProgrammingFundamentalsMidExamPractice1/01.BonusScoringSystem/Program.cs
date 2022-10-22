using System;

namespace _01.BonusScoringSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int bonus = int.Parse(Console.ReadLine());
            decimal maxBonus = decimal.MinValue;
            
            int maxAttendances = 0;
            for (int i = 0; i < students; i++)
            {
                int attendances = int.Parse(Console.ReadLine());
                if(lectures == 0)
                {
                    break;
                }
                decimal totalBonus =  (1.0M * attendances) /(1.0M * lectures) * (5.0M +(1.0M * bonus));
                
                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    maxAttendances = attendances;
                }
            }

            if (students == 0)
            {
                maxBonus = 0;
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendances} lectures.");
        }
    }
}
