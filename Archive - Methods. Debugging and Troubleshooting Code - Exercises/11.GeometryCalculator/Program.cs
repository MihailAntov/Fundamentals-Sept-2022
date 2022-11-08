using System;

namespace _11.GeometryCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch(type)
            {
                case "triangle":
                    double triangleSide = double.Parse(Console.ReadLine());
                    double triangleHeight = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{GetTriangleArea(triangleSide,triangleHeight):f2}");
                    break;
                case "square":
                    double squareSide = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{GetSquareArea(squareSide):f2}");
                    break;
                case "rectangle":
                    double rectangleWidth = double.Parse(Console.ReadLine());
                    double rectangleHeight = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{GetRectangleArea(rectangleWidth,rectangleHeight):f2}");
                    break;
                case "circle":
                    double circleRadius = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{GetCircleArea(circleRadius):f2}");
                    break;
            }
        }

        public static double GetTriangleArea(double side, double height)
        {
            return side * height / 2;
        }

        public static double GetSquareArea(double side)
        {
            return side * side;
        }

        public static double GetRectangleArea(double width, double height)
        {
            return width * height;
        }

        public static double GetCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
