using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> register = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = cmdArgs[0];
                string name = cmdArgs[1];
                

                if(command == "register")
                {
                    string plateNumber = cmdArgs[2];
                    if (register.ContainsKey(name))
                    {
                        //terrible idea, this would allow anyone access to a visitor's car number if they
                        //know the name - massive privacy breach
                        Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                    }
                    else
                    {
                        register.Add(name, plateNumber);
                        Console.WriteLine($"{name} registered {plateNumber} successfully");
                    }
                }
                else if (command == "unregister")
                {
                    
                    if (register.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} unregistered successfully");
                        register.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }
            }

            foreach(KeyValuePair<string, string> parkedCar in register)
            {
                Console.WriteLine($"{parkedCar.Key} => {parkedCar.Value}");
            }
        }
    }
}
