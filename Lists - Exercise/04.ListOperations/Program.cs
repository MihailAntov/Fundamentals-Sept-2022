using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToList();

            string input;

            while ((input = Console.ReadLine())!= "End")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];

                switch(command)
                {
                    case "Add":
                        numbers.Add(int.Parse(cmdArgs[1]));
                        break;
                    case "Insert":
                        if (int.Parse(cmdArgs[2]) < 0 || int.Parse(cmdArgs[2])>= numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        numbers.Insert(int.Parse(cmdArgs[2]), int.Parse(cmdArgs[1]));
                        break;
                    case "Remove":
                        if (int.Parse(cmdArgs[1]) < 0 || int.Parse(cmdArgs[1]) >= numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        numbers.RemoveAt(int.Parse(cmdArgs[1]));
                        break;
                    case "Shift":
                        switch (cmdArgs[1])
                        {
                            case "left":
                                for (int i = 0; i < int.Parse(cmdArgs[2]); i++)
                                {
                                    numbers.Add(numbers[0]);
                                    numbers.RemoveAt(0);
                                    
                                }
                                break;
                            case "right":
                                for (int i = 0; i < int.Parse(cmdArgs[2]); i++)
                                {
                                    numbers.Insert(0, numbers[numbers.Count-1]);
                                    numbers.RemoveAt(numbers.Count-1);
                                }
                                break;
                        }
                        break;
                    

                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
