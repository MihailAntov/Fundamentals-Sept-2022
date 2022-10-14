using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.CarRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] race = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => double.Parse(n))
                .ToArray();

            double firstCarTime = 0;
            double secondCarTime = 0;
            

            for (int i = 0; i < race.Length/2; i++)
            {
                firstCarTime += race[i];
                secondCarTime += race[race.Length -1 -i];

                if (race[i] == 0)
                {
                    firstCarTime *= 0.8;
                  
                }

                if (race[race.Length-1-i] == 0)
                {
                    secondCarTime *= 0.8;
                   
                }
            }

            //for whatever reason decimal does not work
            string winner = string.Empty;
            double winningTime = 0;
           
            if (firstCarTime > secondCarTime)
            {
                //second wins
                winner = "right";
                winningTime = secondCarTime;
            }
            else if (secondCarTime > firstCarTime)
            {
                //first wins
                winner = "left";
                winningTime = firstCarTime;
            }

            if(winner != string.Empty)
            {
                Console.WriteLine($"The winner is {winner} with total time: {winningTime}");
            }

            
        }
    }
}
