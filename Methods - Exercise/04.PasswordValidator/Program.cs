using System;

namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            ValidatePassword(input);

        }

        static void ValidatePassword(string input)
        {
            bool isValid = true;

            if (input.Length < 6 || input.Length > 10)
            {
                isValid = false;
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            int digitCounter = 0;
            bool hasDisplayedError = false;
            foreach (char c in input)
            {
                if (c >= 48 && c <= 57)
                {
                    //digit
                    digitCounter++;
                }
                else if ((c >= 65 && c <= 90) || (c>= 97 && c <= 122))
                {
                    //letter
                }
                else
                {
                    
                    if (!hasDisplayedError)
                    {
                        Console.WriteLine("Password must consist only of letters and digits");
                        hasDisplayedError = true;
                    }
                    isValid = false;
                    
                    
                }
            }

            if (digitCounter < 2)
            {
                isValid = false;
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }

            
        }
    }
}
