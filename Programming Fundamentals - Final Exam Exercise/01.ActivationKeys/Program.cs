using System;

namespace _01.ActivationKeys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rawKey = Console.ReadLine();

            string input;

            while((input = Console.ReadLine()) != "Generate")
            {
                string[] inputArgs = input.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string command = inputArgs[0];

                if(command == "Contains")
                {
                    string substring = inputArgs[1];
                    if(rawKey.Contains(substring))
                    {
                        Console.WriteLine($"{rawKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (command == "Flip")
                {
                    string mode = inputArgs[1];
                    int startIndex = int.Parse(inputArgs[2]);
                    int endIndex = int.Parse(inputArgs[3]);
                    int length = endIndex - startIndex;

                    string subString = rawKey.Substring(startIndex, length);
                    switch (mode)
                    {
                        case "Upper":
                            subString = subString.ToUpper();
                            break;
                        case "Lower":
                            subString = subString.ToLower();
                            break;
                    }
                    rawKey = rawKey
                        .Remove(startIndex, length)
                        .Insert(startIndex,subString);
                    Console.WriteLine(rawKey);

                }
                else if (command == "Slice")
                {
                    int startIndex = int.Parse(inputArgs[1]);
                    int endIndex = int.Parse(inputArgs[2]);
                    int length = endIndex - startIndex;

                    rawKey = rawKey.Remove(startIndex, length);
                    Console.WriteLine(rawKey);
                }
            }

            Console.WriteLine($"Your activation key is: {rawKey}");
        }
    }
}
