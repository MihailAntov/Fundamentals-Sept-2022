using System;
using System.Numerics;

namespace _11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger highestValue = 0;
            short highestValueSnow = 0;
            short highestValueTime = 1;
            byte highestValueQuality = 0;
            for (int i = 1; i <= n; i++)
            {
                short snowBallSnow = short.Parse(Console.ReadLine());
                short snowBallTime = short.Parse(Console.ReadLine());
                byte snowBallQuality = byte.Parse(Console.ReadLine());

                BigInteger snowBallValue = BigInteger.Pow((snowBallSnow / snowBallTime), snowBallQuality);
                if (snowBallValue > highestValue)
                {
                    highestValue = snowBallValue;
                    highestValueSnow = snowBallSnow;
                    highestValueTime = snowBallTime;
                    highestValueQuality = snowBallQuality;
                }
            }
            if(n>0)
            Console.WriteLine($"{highestValueSnow} : {highestValueTime} = {highestValue} ({highestValueQuality})");
        }
    }
}
