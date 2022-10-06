using System;

namespace _01.DataTypeFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            string numbers = "1234567890";
            while (input != "END")
            {
                input = Console.ReadLine();

                //if(Int32.TryParse(input, out int intValue))
                //{
                //    Console.WriteLine($"{input} is integer type");
                //}
                //else if (float.TryParse(input, out float floatValue))
                //{
                //    Console.WriteLine($"{input} is floating point type");
                //}
                //else if (char.TryParse(input, out char charValue))
                //{
                //    Console.WriteLine($"{input} is character type");
                //}
                //else if (bool.TryParse(input, out bool boolValue))
                //{
                //    Console.WriteLine($"{input} is boolean type");
                //}
                //else if (input != "END")
                //{
                //    Console.WriteLine($"{input} is string type");
                //}
                bool isNumber = false;
                bool hasDot = false;

                if(input.Length > 0)
                {
                    isNumber = true;
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (!numbers.Contains(input[i]))
                        {
                            if (i == 0 && input[i] == '-')
                            {
                                continue;
                            }
                            else if (!hasDot && input[i] == '.')
                            {

                                hasDot = true;
                                continue;

                            }
                            else
                            {
                                isNumber = false;
                                break;
                            }

                        }
                    }
                }
                

                if (input.ToLower() == "true" || input.ToLower() == "false")
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else if (isNumber)
                {
                    if(input.Contains('.'))
                    {
                        Console.WriteLine($"{input} is floating point type");
                    }
                    else 
                    {
                        Console.WriteLine($"{input} is integer type");
                    }
                }
                else if (input.Length < 2)
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (input != "END")
                {
                    Console.WriteLine($"{input} is string type");
                }
            }


        }
    }
}
