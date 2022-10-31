using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _05.NetherRealms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string nameFilter = @"\s*(?<name>[a-zA-Z\d\-\*]+)\s*";
            string contentsFilter = @"(?<negative>\-[0-9]*)|[^\-](?<positive>[0-9])|(?<multiply>\*)|(?<divide>\/)";

            MatchCollection names = Regex.Matches(input, nameFilter);

            foreach (Match m in names)
            {
                string name = m.Name;
                MatchCollection contents = Regex.Matches(name, contentsFilter);
                
                foreach (Match match in contents)
                {
                    sumOfPositive += int.Parse(match.Groups["positive"].Value);
                    sumOfNegative += int.Parse(match.Groups["negative"].Value);
                    if (match.Groups["divide"].Length>0)
                    {
                        countOfDivide++;
                    }
                    if (match.Groups["multiply"].Length > 0)
                    {
                        countOfMultiply++;
                    }
                }

                decimal baseDamage = 1.0M * (sumOfPositive + sumOfNegative);
                for (int i = 0; i < countOfMultiply; i++)
                {
                    baseDamage *= 2.0M; ;
                }

                for (int i = 0; i < countOfDivide; i++)
                {
                    baseDamage /= 2.0M;
                }


            }
        }
    }
}
