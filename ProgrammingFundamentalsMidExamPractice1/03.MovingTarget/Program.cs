using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MovingTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToList();

            string input;

            while ((input = Console.ReadLine())!= "End")
            {
                string[] cmdArgs = input.Split(" ");

                string command = cmdArgs[0];
                int index = int.Parse(cmdArgs[1]);
                int value = int.Parse(cmdArgs[2]);

                bool isValidIndex = true;
                if(index < 0 || index >= targets.Count)
                {
                    isValidIndex = false;
                }
                switch (command)
                {
                    case "Shoot":
                        if (isValidIndex)
                        {
                            targets[index] -= value;
                            if (targets[index] <= 0)
                            {
                                targets.RemoveAt(index);
                            }
                        }
                        break;
                    case "Add":
                        if(isValidIndex)
                        {
                            targets.Insert(index, value);
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }

                        break;
                    case "Strike":
                        if (index - value < 0 || index + value >= targets.Count)
                        {
                            isValidIndex = false;
                        }

                        if (isValidIndex)
                        {
                            targets.RemoveRange(index - value, 2 * value + 1);
                        }
                        else
                        {
                            Console.WriteLine("Strike missed!");
                        }
                        break;
                }

                
            }
            Console.WriteLine(String.Join("|", targets));
        }
    }
}
