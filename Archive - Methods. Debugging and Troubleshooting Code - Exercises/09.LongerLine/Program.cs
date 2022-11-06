using System;

namespace _09.LongerLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstX1 = double.Parse(Console.ReadLine());
            double firstY1 = double.Parse(Console.ReadLine());
            double firstX2 = double.Parse(Console.ReadLine());
            double firstY2 = double.Parse(Console.ReadLine());

            double secondX1 = double.Parse(Console.ReadLine());
            double secondY1 = double.Parse(Console.ReadLine());
            double secondX2 = double.Parse(Console.ReadLine());
            double secondY2 = double.Parse(Console.ReadLine());

            Line lineOne = new Line();
            lineOne.GetCloserAndFurtherPoint(new Point(firstX1, firstY1), new Point(firstX2, firstY2));

            Line lineTwo = new Line();
            lineTwo.GetCloserAndFurtherPoint(new Point(secondX1, secondY1), new Point(secondX2, secondY2));

            if (lineOne.GetLineLength() >= lineTwo.GetLineLength())
            {
                Console.WriteLine(lineOne);
            }
            else
            {
                Console.WriteLine(lineTwo);
            }

        }

        

        
    }

    public class Line
    {
        public Point PointA { get; set; }
        public Point PointB { get; set; }
        public double GetLineLength()
        {
            return Math.Abs(Math.Abs(PointB.X - PointA.X) + Math.Abs(PointB.Y - PointA.Y)); 
        }

        public void GetCloserAndFurtherPoint(Point a, Point b)
        {
            double distanceOfFirst = Math.Abs(a.X) + Math.Abs(a.Y);
            double distanceOfSecond = Math.Abs(b.X) + Math.Abs(b.Y);

            if (distanceOfFirst <= distanceOfSecond)
            {
                PointA = a;
                PointB = b;
            }
            else
            {
                PointA = b;
                PointB = a;
            }

        }

        public override string ToString()
        {
            return$"({PointA.X}, {PointA.Y})({PointB.X}, {PointB.Y})";
        }
    }

    public class Point
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; set; }
        public double Y { get; set; }
    }
}
