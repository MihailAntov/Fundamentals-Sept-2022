using System;
using System.Linq;

namespace _02.ManipulateArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = cmdArgs[0];

                switch(command)
                {
                    case "Reverse":
                        strings = Reverse(strings);
                        break;
                    case "Distinct":
                        strings = Distinct(strings);
                        break;
                    case "Replace":
                        int index = int.Parse(cmdArgs[1]);
                        string newString = cmdArgs[2];
                        strings = Replace(strings, index, newString);
                        break;
                }
            }

            Console.WriteLine(String.Join(", ",strings));
        }

        public static string[] Reverse(string[] strings)
        {
            string[] result = new string[strings.Length];
            for (int i = 0; i < strings.Length; i++)
            {
                result[strings.Length - 1 - i] = strings[i];
            }
            return result;
            //return strings.Reverse().ToArray();
        }
        public static string[] Distinct(string[] strings)
        {
            return strings.Distinct().ToArray();
        }
        public static string[] Replace(string[] strings, int index, string newString)
        {
            strings[index] = newString;
            return strings;
        }
    }
}
