using System;

namespace _01.PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string input;
            while((input = Console.ReadLine()) != "Done")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];

                switch(command)
                {
                    case "TakeOdd":
                        password = TakeOdd(password);
                        Console.WriteLine(password);
                        break;
                    case "Cut":
                        int index = int.Parse(cmdArgs[1]);
                        int length = int.Parse(cmdArgs[2]);
                        password = password.Remove(index, length);
                        Console.WriteLine(password);
                        break;
                    case "Substitute":
                        string subString = cmdArgs[1];
                        string substitute = cmdArgs[2];
                        if(password.Contains(subString))
                        {
                            password = password.Replace(subString, substitute);
                            Console.WriteLine(password);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                }
            }

            Console.WriteLine($"Your password is: {password}");
        }

        public static string TakeOdd(string input)
        {
            string result = string.Empty;
            for (int i = 1; i < input.Length; i+=2)
            {
                result += input[i];
            }
            return result;

        }
    }
}
