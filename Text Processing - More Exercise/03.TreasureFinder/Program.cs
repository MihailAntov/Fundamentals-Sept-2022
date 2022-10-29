using System;
using System.Linq;

namespace _03.TreasureFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();

            string input;

            while ((input = Console.ReadLine())!= "find")
            {
                string decryptedString = String.Empty;

                for (int i = 0; i < input.Length; i++)
                {
                    char nextChar = (char)(input[i] - key[i%key.Length]);
                    decryptedString += nextChar;
                }

                int startOfType = decryptedString.IndexOf('&')+1;
                int endOfType = decryptedString.LastIndexOf('&');
                int lengthOfType = endOfType  - startOfType;

                int startOfCoordinates = decryptedString.IndexOf('<')+1;
                int endOfCoordinates = decryptedString.IndexOf('>');
                int lengthOfCoordinates = endOfCoordinates - startOfCoordinates;

                

                string typeOfTreasure = decryptedString.Substring(startOfType, lengthOfType);
                string coordinatesOfTreasure = decryptedString.Substring(startOfCoordinates, lengthOfCoordinates);

                Console.WriteLine($"Found {typeOfTreasure} at {coordinatesOfTreasure}");
            }

        }
    }
}
