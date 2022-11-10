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
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            while ((input = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];
                


                if (command == "A")
                {
                    string name = cmdArgs[1];
                    string phone = cmdArgs[2];
                    if (!phonebook.ContainsKey(name))
                    {
                        phonebook.Add(name, phone);
                    }

                    phonebook[name] = phone;
                }
                else if (command == "S")
                {
                    string name = cmdArgs[1];
                    if (!phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                        continue;
                    }

                    Console.WriteLine($"{name} -> {phonebook[name]}");

                }
                else if (command == "ListAll")
                {
                    foreach (KeyValuePair<string, string> entry in phonebook)
                    {
                        Console.WriteLine($"{entry.Key} -> {entry.Value}");
                    }
                }
            }
        }
    }
}
