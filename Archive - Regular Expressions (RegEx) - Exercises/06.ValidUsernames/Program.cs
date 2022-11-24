using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _06.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string pattern = @"\b(?<user>[A-Za-z]\w{2,24})([\\\/ ()]|$)";
            Regex regex = new Regex(pattern);

            string[] validUsers = regex.Matches(Console.ReadLine())
                .Select(n => n.Groups["user"].Value)
                .ToArray();
            //----------------
            //int maxIndex = validUsers
            //    .SkipLast(1)
            //    .OrderByDescending(n => n.Length + validUsers[Array.IndexOf(validUsers, n) + 1].Length)
            //    .ThenBy(n=>Array.IndexOf(validUsers,n))
            //    .Select(n => Array.IndexOf(validUsers, n))
            //    .FirstOrDefault();
            //----------------
            //the above does not work - the second to last test in Judge fails.
            //Appears to be due to the ordering by index in cases when
            // several identical entries are present

            int maxIndex = -1;
            int maxSum = 0;

            for (int i = 0; i < validUsers.Length - 1; i++)
            {
                if (validUsers[i].Length + validUsers[i + 1].Length > maxSum)
                {
                    maxIndex = i;
                    maxSum = validUsers[i].Length + validUsers[i + 1].Length;
                }
            }

            Console.WriteLine(validUsers[maxIndex]);
            Console.WriteLine(validUsers[maxIndex + 1]);
        }
    }
}
