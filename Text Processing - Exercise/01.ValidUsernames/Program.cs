using System;
using System.Linq;
namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(", ");
            foreach (string name in names.Where(n=> IsValidUsername(n)))
            {
                Console.WriteLine(name);
            }

        }

        public static bool IsValidUsername(string name)
        {
            if(name.Length < 3 || name.Length > 16)
            {
                return false;
            }

            foreach (char c in name)
            {
                if (!char.IsLetter(c) && !char.IsNumber(c) && c!= '_' && c != '-')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
