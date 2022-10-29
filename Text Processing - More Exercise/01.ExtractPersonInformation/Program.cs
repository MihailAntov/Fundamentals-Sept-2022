using System;

namespace _01.ExtractPersonInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int startOfName = input.IndexOf('@')+1;
                int lengthOfName = input.IndexOf('|') - startOfName;

                int startOfAge = input.IndexOf('#')+1;
                int lengthOfAge = input.IndexOf('*') - startOfAge;

                string name = input.Substring(startOfName, lengthOfName);
                int age = int.Parse(input.Substring(startOfAge, lengthOfAge));
                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
