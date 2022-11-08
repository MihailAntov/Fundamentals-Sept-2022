using System;

namespace _10.CubeProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            switch(Console.ReadLine())
            {
                case "face":
                    Console.WriteLine($"{GetFace(side):f2}");
                    break;
                case "space":
                    Console.WriteLine($"{GetSpace(side):f2}");
                    break;
                case "volume":
                    Console.WriteLine($"{GetVolume(side):f2}");
                    break;
                case "area":
                    Console.WriteLine($"{GetArea(side):f2}");
                    break;
            }
        }

        public static double GetFace(double side)
        {
            return Math.Sqrt(2 * side * side);
        }
        public static double GetSpace(double side)
        {
            return Math.Sqrt(3*side * side);
        }
        public static double GetVolume(double side)
        {
            return side * side * side;
        }
        public static double GetArea(double side)
        {
            return 6 * side * side;
        }
    }
}
