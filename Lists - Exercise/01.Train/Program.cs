using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> trains = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxPassengers = int.Parse(Console.ReadLine());

            string command;

            while ((command=Console.ReadLine())!= "end")
            {
                string[] cmdArgs = command.Split(" ");

                switch(cmdArgs[0])
                {
                    case "Add":
                        trains.Add(int.Parse(cmdArgs[1]));
                        break;
                    default:
                        for (int i = 0; i <trains.Count; i++)
                        {
                            if (trains[i] + int.Parse(cmdArgs[0]) <= maxPassengers)
                            {
                                trains[i] += int.Parse(cmdArgs[0]);
                                break;
                            }
                        }
                        break;
                }
            }

            Console.WriteLine(String.Join(" ", trains));
        }
    }
}
