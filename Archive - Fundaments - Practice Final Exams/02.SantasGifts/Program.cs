using System;
using System.Linq;
using System.Collections.Generic;
namespace _02.SantasGifts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int position = 0;
            List<int> houses = Console.ReadLine()
                .Split(' ')
                .Select(n => int.Parse(n))
                .ToList();

            for (int i = 0; i < n; i ++)
            {
                string[] inputArgs = Console.ReadLine()
                    .Split(' ');
                string command = inputArgs[0];

                if(command == "Forward")
                {
                    int steps = int.Parse(inputArgs[1]);

                    if(steps + position >= houses.Count)
                    {
                        continue;
                    }
                    position += steps;
                    houses.RemoveAt(position); 
                }
                else if (command == "Back")
                {
                    int steps = int.Parse(inputArgs[1]);
                    if(position - steps < 0)
                    {
                        continue;
                    }
                    position -= steps;
                    houses.RemoveAt(position);
                }
                else if (command == "Gift")
                {
                    int index = int.Parse(inputArgs[1]);
                    int value = int.Parse(inputArgs[2]);
                    if(index < 0 || index > houses.Count)
                    {
                        continue;
                    }
                    houses.Insert(index, value);
                    position = index;
                }
                else if (command == "Swap")
                {
                    int value1 = int.Parse(inputArgs[1]);
                    int value2 = int.Parse(inputArgs[2]);
                    if(!houses.Contains(value1) || !houses.Contains(value2))
                    {
                        continue;
                    }

                    int index1 = houses.IndexOf(value1);
                    int index2 = houses.IndexOf(value2);
                    houses[index1] = value2;
                    houses[index2] = value1;
                }
            }

            Console.WriteLine($"Position: {position}");
            Console.WriteLine(String.Join(", ",houses));
        }
    }
}
