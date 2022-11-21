using System;
using System.Collections.Generic;
using System.Linq;
namespace _07.PlayCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(n => int.Parse(n))
                .ToArray();
            int errors = 0;
            while(errors < 3)
            {
                string[] commandArgs = Console.ReadLine().Split(' ');
                string command = commandArgs[0];

                int valueOne;
                bool successOne = int.TryParse(commandArgs[1], out valueOne);
                if (!successOne)
                {
                    Console.WriteLine($"The variable is not in the correct format!");
                    errors++;
                    continue;
                }

                if(command == "Replace")
                {
                    int valueTwo;
                    bool success = int.TryParse(commandArgs[2], out valueTwo);
                    if(!success)
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                        errors++;
                        continue;
                    }
                    try
                    {
                        numbers[valueOne] = valueTwo;
                    }
                    catch
                    {
                        Console.WriteLine("The index does not exist!");
                        errors++;
                    }
                }
                else if (command == "Print")
                {
                    int valueTwo;
                    bool success = int.TryParse(commandArgs[2], out valueTwo);
                    if (!success)
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                        errors++;
                        continue;
                    }
                    try
                    {
                        List<int> result = new List<int>();
                        for (int i = valueOne; i <= valueTwo; i++)
                        {
                            result.Add(numbers[i]);
                        }

                        Console.WriteLine(String.Join(", ", result));
                    }
                    catch
                    {
                        Console.WriteLine("The index does not exist!");
                        errors++;
                    }

                }
                else if (command == "Show")
                {
                    try
                    {
                        Console.WriteLine(numbers[valueOne]);
                    }
                    catch
                    {
                        Console.WriteLine("The index does not exist!");
                        errors++;
                    }
                }
                
            }

            Console.WriteLine(String.Join(", ",numbers));
        }

        

        
    }
}
