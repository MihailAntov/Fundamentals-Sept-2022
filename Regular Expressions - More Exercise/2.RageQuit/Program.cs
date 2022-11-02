using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;


namespace _2.RageQuit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textFilter = @"\D+";
            string numberFilter = @"\d+";
            string input = Console.ReadLine();
            string[] textInputs = Regex.Matches(input, textFilter).Select(n=>n.Value).ToArray();
            int[] numberInputs = Regex.Matches(input, numberFilter).Select(n=>int.Parse(n.Value)).ToArray();
            
            StringBuilder strBuilder = new StringBuilder();
            for(int i = 0; i < textInputs.Length; i++)
            {
                int repetitions = numberInputs[i];
                string text = textInputs[i];
                for (int j = 0; j < repetitions; j++)
                {
                    strBuilder.Append(text.ToUpper());
                }
            }

            
            char[] symbols = strBuilder.ToString().Distinct().ToArray();
            int uniqueSymbols = symbols.Length;

            Console.WriteLine($"Unique symbols used: {uniqueSymbols}");
            Console.WriteLine(strBuilder);
            

            
        }
    }

    
}
