using System;

namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gamesLost = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int keyboardCounter = 0;
            double rageExpenses = 0;

            for (int i = 1; i <= gamesLost; i++)
            {
                if(i % 2 == 0)
                {
                    rageExpenses += headsetPrice;
                }

                if (i % 3 == 0)
                {
                    rageExpenses += mousePrice;
                }

                if (i%2 == 0 && i % 3 == 0)
                {
                    rageExpenses += keyboardPrice;

                    keyboardCounter++;
                    if(keyboardCounter % 2 == 0)
                    {
                        rageExpenses += displayPrice;
                    }
                }


            }
            Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");
        }
    }
}
