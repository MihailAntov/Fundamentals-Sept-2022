using System;
using System.Linq;

namespace _02.ArrayModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();

            string input;

            while ((input= Console.ReadLine())!= "end")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];

                switch (command)
                {
                    case "swap":
                        int index1 = int.Parse(cmdArgs[1]);
                        int index2 = int.Parse(cmdArgs[2]);

                        int buffer = numbers[index1];
                        numbers[index1] = numbers[index2];
                        numbers[index2] = buffer;
                        break;
                    case "multiply":
                        int indexResult = int.Parse(cmdArgs[1]);
                        int indexMultiplier = int.Parse(cmdArgs[2]);

                        numbers[indexResult]*= numbers[indexMultiplier];
                        break;
                    case "decrease":
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numbers[i] -= 1;
                        }
                        break;
                }
            }

            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}
