using System;

namespace _09.MelrahShake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (pattern.Length > 0 && input.Length >= pattern.Length)
            {
                if(Ocurrences(input, pattern) < 2)
                {

                    break;
                }

                input = input.Remove(input.LastIndexOf(pattern), pattern.Length);
                input = input.Remove(input.IndexOf(pattern), pattern.Length);
                pattern = pattern.Remove(pattern.Length/2,1);
                Console.WriteLine("Shaked it.");
            }
            Console.WriteLine("No shake.");
            Console.WriteLine(input);
        }

        public static int Ocurrences(string input, string pattern)
        {
            if(!input.Contains(pattern))
            {
                return 0;
            }

            int count = 0;

            while(input.Contains(pattern))
            {
                input = input.Substring(input.IndexOf(pattern) + pattern.Length);
                count++;
            }
            return count;
        }
    }
}
