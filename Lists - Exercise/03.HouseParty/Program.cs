using System;
using System.Collections.Generic;

namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i <n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(' ');
                string name = cmdArgs[0];

                if (cmdArgs[2] == "not")
                {
                    //not going
                    if (!guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                    else
                    {
                        guests.Remove(name);
                    }


                }
                else
                {
                    //going
                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guests.Add(name);
                    }
                }
            }

            foreach (string guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
