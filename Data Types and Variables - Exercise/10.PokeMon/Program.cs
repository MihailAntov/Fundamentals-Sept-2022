using System;

namespace _10.PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int powerN = int.Parse(Console.ReadLine());
            int startingPowerN = powerN;
            int distanceM = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());
            int pokeCount = 0;


            while (powerN >= distanceM)
            {
                powerN -= distanceM;
                pokeCount++;
                if(powerN * 2 == startingPowerN)
                {
                    if(exhaustionFactorY > 1)
                    {
                        powerN /= exhaustionFactorY;
                    }
                }
            }
            Console.WriteLine(powerN);
            Console.WriteLine(pokeCount);
        }
    }
}
