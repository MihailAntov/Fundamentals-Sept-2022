using System;

namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string highestCapacityModel = string.Empty;
            double highestCapacity = 0.0f;
            for (int i = 0; i < n; i++)
            {
                string nextModel = Console.ReadLine();
                double nextRadius = float.Parse(Console.ReadLine());
                int nextHeight = int.Parse(Console.ReadLine());
                double nextCapacity = nextRadius * nextRadius * nextHeight;
                if (nextCapacity > highestCapacity)
                {
                    highestCapacity = nextCapacity;
                    highestCapacityModel = nextModel;
                }
                //ignoring Math.PI since actual numerical value of the volume is not needed and each volume is multiplied by Math.PI , making it a constant
            }
            Console.WriteLine(highestCapacityModel);

        }
    }
}
