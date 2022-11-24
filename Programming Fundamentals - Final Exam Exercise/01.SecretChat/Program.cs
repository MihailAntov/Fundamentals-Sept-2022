using System;
using System.Text;

namespace _01.SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string input;
            
            
            while((input = Console.ReadLine()) != "Reveal")
            {
                string[] inputArgs = input
                    .Split(":|:", StringSplitOptions.RemoveEmptyEntries);

                string command = inputArgs[0];

                switch(command)
                {
                    case "InsertSpace":
                        int index = int.Parse(inputArgs[1]);
                        message = message.Insert(index, " ");
                        Console.WriteLine(message);
                        break;
                    case "Reverse":
                        string substringToReverse = inputArgs[1];
                        message = Reverse(substringToReverse, message);
                        break;
                    case "ChangeAll":
                        string subStringToReplace = inputArgs[1];
                        string replacement = inputArgs[2];
                        message = message.Replace(subStringToReplace, replacement);
                        Console.WriteLine(message);
                        break;
                }
                
            }

            Console.WriteLine($"You have a new text message: {message}");
            
        }

        public static string Reverse(string substringToReverse, string message)
        {
            if(!message.Contains(substringToReverse))
            {
                Console.WriteLine("error");
                return message;
            }

            string reversedSubString = string.Empty;

            for(int i = 0; i < substringToReverse.Length; i++)
            {
                reversedSubString = reversedSubString.Insert(0, substringToReverse[i].ToString());
            }
            int indexOfSubString = message.IndexOf(substringToReverse);
            int length = substringToReverse.Length;
            message = message.Substring(0, indexOfSubString) + message.Substring(indexOfSubString + length);
            message += reversedSubString;
            Console.WriteLine(message);
            return message;


        }
    }
}
