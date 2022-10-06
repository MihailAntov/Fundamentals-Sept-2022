using System;

namespace _01.DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            string input = Console.ReadLine();
            HandleInput(dataType, input);
        }

        static void HandleInput(string type, string input)
        {
            switch (type)
            {
                case "int":
                    PrintResult(int.Parse(input));
                    break;
                case "real":
                    PrintResult(double.Parse(input));
                    break;
                case "string":
                    PrintResult(input);
                    break;
            }
        }
        static void PrintResult(string input)
        {
            Console.WriteLine($"${input}$");
        }
        static void PrintResult(int input)
        {
            Console.WriteLine(input * 2);
        }
        static void PrintResult(double input)
        {
            Console.WriteLine($"{input * 1.5:f2}");
        }
    }
}
