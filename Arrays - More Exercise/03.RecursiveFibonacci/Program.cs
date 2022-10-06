using System;

namespace _03.RecursiveFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int GetFibonacci(int n)
            {
                if(n == 1)
                {
                    return 1;
                }

                if (n == 2)
                {
                    return 1;
                }

                return (GetFibonacci(n - 1) + GetFibonacci(n - 2));
            }

            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFibonacci(n)); 
        }
        
    }
}
