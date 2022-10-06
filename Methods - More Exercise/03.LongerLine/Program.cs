using System;

namespace _03.LongerLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            if(FindLength(x1,y1,x2,y2) < FindLength(x3,y3,x4,y4))
            {
                FindClosest(x3, y3, x4, y4);
            }
            else
            {
                FindClosest(x1, y1, x2, y2);
            }


        }

        static void FindClosest(double x1, double y1, double x2, double y2)
        {
            double distance1 = Math.Abs(x1) + Math.Abs(y1);
            double distance2 = Math.Abs(x2) + Math.Abs(y2);

            if (distance1 > distance2)
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
        }

        static double FindLength(double x1, double y1, double x2, double y2)
        {
            return Math.Abs(x1-x2) + Math.Abs(y1 - y2);
        }
    }
}
