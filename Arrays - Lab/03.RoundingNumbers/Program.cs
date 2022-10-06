using System;
using System.Text;
using System.Linq;

namespace _03.RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            //double[] numbers = input.Split(' ').Select(n => double.Parse(n)).ToArray();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"{numbers[i]} => {(int)Math.Round(numbers[i], MidpointRounding.AwayFromZero)}");
            //}

            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            foreach (string number in numbers)
            {
                Console.WriteLine($"{double.Parse(number)} => {(int)Math.Round(Double.Parse(number), MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
