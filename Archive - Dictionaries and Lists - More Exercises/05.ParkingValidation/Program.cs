using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.ParkingValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> plates = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] intputArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = intputArgs[0];
                string username = intputArgs[1];

                if(command == "register")
                {
                    string plate = intputArgs[2];
                    
                    if(plates.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plates[username]}");
                    }
                    else if (!IsValidPlate(plate))
                    {
                        Console.WriteLine($"ERROR: invalid license plate {plate}");
                    }
                    else if (plates.ContainsValue(plate))
                    {
                        Console.WriteLine($"ERROR: license plate {plate} is busy");
                    }
                    else
                    {
                        Console.WriteLine($"{username} registered {plate} successfully");
                        plates.Add(username, plate);
                    }
                    
                }
                else if (command == "unregister")
                {
                    if(!plates.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        Console.WriteLine($"user {username} unregistered successfully");
                        plates.Remove(username);
                    }
                }
            }

            foreach(KeyValuePair<string, string> plate in plates)
            {
                Console.WriteLine($"{plate.Key} => {plate.Value}");
            }
        }

        public static bool IsValidPlate(string input)
        {
            if(input.Length != 8)
            {
                return false;
            }

            char[] upperChars = new char[4] { input[0], input[1], input[6], input[7] };
            if(upperChars.Any(n=>!char.IsUpper(n)))
            {
                return false;
            }

            char[] numbers = new char[4];
            numbers = input[2..5].ToCharArray();
            if(numbers.Any(n=>!char.IsDigit(n)))
            {
                return false;
            }
            return true;
        }
    }
}
