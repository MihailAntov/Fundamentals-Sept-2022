using System;


namespace _02.FromLeftToTheRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] numbers = input.Split(' ');
                double leftNumber = double.Parse(numbers[0]);
                double rightNumber = double.Parse(numbers[1]);
                int sum = 0;

                if (leftNumber > rightNumber)
                {
                    for(int j = 0; j < numbers[0].Length; j++)
                    {
                        if (numbers[0][j]!= '.' && numbers[0][j] != '-')
                        {
                            sum += Math.Abs(int.Parse(numbers[0][j].ToString()));
                        }
                    }
                    Console.WriteLine(sum);
                }
                else
                {
                    for (int j = 0; j < numbers[1].Length; j++)
                    {
                        if (numbers[1][j]!='.' && numbers[1][j] != '-')
                        {
                            sum += Math.Abs(int.Parse(numbers[1][j].ToString()));
                        }
                        
                    }
                    Console.WriteLine(sum);
                }
            }
        }
    }
}
