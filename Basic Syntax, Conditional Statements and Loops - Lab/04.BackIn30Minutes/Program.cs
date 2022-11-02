using System;

namespace _04.BackIn30Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int totalMinutes = 60 * hours + minutes + 30;
            Console.WriteLine($"{(totalMinutes/60)%24}:{totalMinutes%60:D2}");
        }
    }
}
