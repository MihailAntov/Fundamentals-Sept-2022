using System;

namespace _02.MaxMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(a, GetMax(b,c)));
        }

        public static int GetMax(int a, int b)
        {
            int result = a > b ? a : b;
            return result;
                
        }
    }
}
