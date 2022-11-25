using System;
using System.Linq;
namespace _04.MorseCodeUpgraded
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split("|");

            char[] chars = input
                .Select(n => (char)Decode(n))
                .ToArray();
            Console.WriteLine(String.Join("", chars));


        }

        public static int Decode(string s)
        {
            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '0')
                {
                    result += 3;
                }
                else if (s[i] == '1')
                {
                    result += 5;
                }


                if (i == s.Length - 1)
                {
                    int samecount = 1;
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (s[i] == s[j])
                        {
                            samecount++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (samecount > 1)
                    {
                        result += samecount;
                    }
                    continue;
                }

                if (s[i] != s[i + 1])
                {
                    int samecount = 1;
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (s[i] == s[j])
                        {
                            samecount++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (samecount > 1)
                    {
                        result += samecount;
                    }
                }

            }

            return result;
        }
    }
}
