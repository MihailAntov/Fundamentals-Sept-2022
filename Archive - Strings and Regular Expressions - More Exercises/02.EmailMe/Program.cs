using System;
using System.Linq;
namespace _02.EmailMe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();

            string before = email.Substring(0, email.IndexOf('@'));
            string after = email.Substring(email.IndexOf('@') + 1);

            int beforeSum = before.Select(n => (int)n).Sum();
            int afterSum = after.Select(n => (int)n).Sum();

            if(beforeSum-afterSum >=0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}
