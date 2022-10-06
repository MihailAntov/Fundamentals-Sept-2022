using System;

namespace _05.Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int length = input.Length;
                int mainNumber = int.Parse(input) % 10;

                int offset = (mainNumber - 2) * 3;
                if (mainNumber > 7)
                {
                    offset++;
                }
                int index = offset - 1 + length;
                if (mainNumber == 0)
                {
                    result += " ";
                }
                else
                {
                    result += (char)(97 + index);
                }
                
            }

            Console.WriteLine(result);
            
            
        }
    }
}
