using System;

namespace _09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();

            switch (type)
            {
                case "string":
                    Console.WriteLine(CalculateHigherValue(firstValue, secondValue));
                    break;
                    case "int":
                    Console.WriteLine(CalculateHigherValue((int.Parse(firstValue)), int.Parse(secondValue)));
                    break;
                case "char":
                    Console.WriteLine(CalculateHigherValue((char.Parse(firstValue)), char.Parse(secondValue)));
                    break;

            }
        }

        static string CalculateHigherValue(string firstValue, string secondValue)
        {
            int comparison = firstValue.CompareTo(secondValue);
            

            if (comparison > 0)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }

        }

        static string CalculateHigherValue(char firstValue, char secondValue)
        {
            return ((char)(Math.Max((int)firstValue, (int)secondValue))).ToString();
        }

        static string CalculateHigherValue(int firstValue, int secondValue)
        {
            return (Math.Max(firstValue, secondValue)).ToString();
        }
    }
}
