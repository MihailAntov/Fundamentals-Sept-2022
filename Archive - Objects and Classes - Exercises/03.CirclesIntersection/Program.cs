using System;

namespace _03.CirclesIntersection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Circle first = new Circle(int.Parse(cmdArgs[0]), int.Parse(cmdArgs[1]), double.Parse(cmdArgs[2]));

            cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Circle second = new Circle(int.Parse(cmdArgs[0]), int.Parse(cmdArgs[1]), double.Parse(cmdArgs[2]));

            double distance = Math.Sqrt(Math.Abs(Math.Pow((first.Center.X - second.Center.X), 2) + Math.Pow((first.Center.Y - second.Center.Y), 2)));
            if(distance > first.Radius+ second.Radius)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }
    }

    public class Circle
    {
        public Circle(int x, int y, double radius)
        {
            Center = new Point(x, y);
            Radius = radius;
        }

        public Point Center { get; set; }
        public double Radius { get; set; }
    }

    public class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
