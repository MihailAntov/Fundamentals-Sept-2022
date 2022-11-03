using System;

namespace _01.TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string input;

            while((input = Console.ReadLine()) != "Decode")
            {
                string[] cmdArgs = input.Split("|",StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];

                switch(command)
                {
                   
                    case "Move":
                        int numberOfLetters = int.Parse(cmdArgs[1]);
                        string lettersToBeMoved = message.Substring(0, numberOfLetters);
                        message = string.Concat(message.Substring(numberOfLetters), lettersToBeMoved);
                        break;
                    case "Insert":
                        int index = int.Parse(cmdArgs[1]);
                        string value = cmdArgs[2];
                        message = message.Insert(index, value);
                        break;
                    case "ChangeAll":
                        string subString = cmdArgs[1];
                        string replacement = cmdArgs[2];
                        message = message.Replace(subString, replacement);
                        break;
                }
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
