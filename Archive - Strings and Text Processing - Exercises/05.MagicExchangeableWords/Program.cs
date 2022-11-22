using System;
using System.Collections.Generic;

namespace _05.MagicExchangeableWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Console.WriteLine(Exchangeable(input[0], input[1]).ToString().ToLower());
        }

        public static bool Exchangeable(string inputA, string inputB)
        {
            string a;
            string b;
            if(inputA.Length>= inputB.Length)
            {
                a = inputA;
                b = inputB;
            }
            else
            {
                a = inputB;
                b = inputA;
            }


            Dictionary<char, char> map = new Dictionary<char, char>();
            for (int i = 0; i < b.Length; i++)
            {
                if (!map.ContainsKey(a[i]))
                {
                    map.Add(a[i], b[i]);
                }
                else
                {
                    if (map[a[i]] != b[i])
                    {
                        return false;
                    }
                }
            }

            for (int i = b.Length; i < a.Length; i++)
            {
                if (!map.ContainsKey(a[i]))
                {
                    return false;
                }
            }
            

            return true;
        }
    }
}
