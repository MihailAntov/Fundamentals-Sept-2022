using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Phonebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            while((input = Console.ReadLine())!= "END")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];
                string name = cmdArgs[1];
                

                if(command == "A")
                {
                    string phone = cmdArgs[2];
                    if (!phonebook.ContainsKey(name))
                    {
                        phonebook.Add(name, phone);
                    }

                    phonebook[name] = phone;
                }
                else if (command == "S")
                {
                    if(!phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                        continue;
                    }

                    Console.WriteLine($"{name} -> {phonebook[name]}");

                }
            }
        }
    }
}
