using System;

namespace _08.CenterPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            GetCloserPoint(x1,y1,x2,y2);
        }

        public static void GetCloserPoint(double x1, double y1, double x2, double y2)
        {
            double distanceOfFirst = Math.Abs(x1) + Math.Abs(y1);
            double distanceOfSecond = Math.Abs(x2) + Math.Abs(y2);

            if(distanceOfFirst <= distanceOfSecond)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
