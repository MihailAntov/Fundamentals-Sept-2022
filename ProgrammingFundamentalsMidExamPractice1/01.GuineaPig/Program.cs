using System;

namespace _2_01.GuineaPig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal food = decimal.Parse(Console.ReadLine());
            decimal hay = decimal.Parse(Console.ReadLine());
            decimal cover = decimal.Parse(Console.ReadLine());
            decimal weight = decimal.Parse(Console.ReadLine());
            bool enough = true;
            
            for (int dayCounter = 1; dayCounter <= 30; dayCounter++)
            {
                

                food -= 0.3M;
                if(food <=0)
                {
                    enough = false;
                    break;
                }

                if(dayCounter %2 == 0)
                {
                    hay -= 0.05M * food;
                    if (hay <=0)
                    {
                        enough = false;
                        break;
                    }
                }

                if (dayCounter % 3 == 0)
                {
                    cover -= weight / 3.0M;
                    if(cover <= 0)
                    {
                        enough = false;
                        break;
                    }
                }
            }
            if (enough)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food:f2}, Hay: {hay:f2}, Cover: {cover:f2}.");
            }
            else
            {
                Console.WriteLine("Merry must go to the pet store!");
            }

        }
    }
}
