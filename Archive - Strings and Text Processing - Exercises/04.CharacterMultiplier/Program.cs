using System;

namespace _04.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Console.WriteLine(CombineCharacterCodes(input[0], input[1]));
        }

        static int CombineCharacterCodes(string a, string b)
        {
            int sum = 0;
            for (int i = 0; i < Math.Max(a.Length, b.Length); i++)
            {
                int first = (i < a.Length) ? (int)a[i] : 1;
                int second = (i < b.Length) ? (int)b[i] : 1;

                sum += first * second;
            }

            return sum;
        }
    }
}
