using System;

namespace _06.BalancedBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool balanced = true;
            bool hasOpeningBracket = false;
            int openingBrackets = 0;
            int closingBrackets = 0;
            

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                
                if (input == "(" && hasOpeningBracket)
                {
                    balanced = false;
                    openingBrackets++;
                }
                else if (input == "(" && !hasOpeningBracket)
                {
                    
                    hasOpeningBracket = true;
                    openingBrackets++;
                }
                else if (input == ")" && !hasOpeningBracket)
                {
                    balanced = false;
                    closingBrackets++;
                }
                else if (input == ")" && hasOpeningBracket)
                {
                    hasOpeningBracket = false;
                    closingBrackets++;
                }
            }

            if (openingBrackets != closingBrackets)
            {
                balanced = false;
            }
            if (balanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
