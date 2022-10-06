using System;

namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int trips = people / capacity;
            if(people % capacity != 0)
            {
                trips++;
            }
            Console.WriteLine(trips);
        }
    }
}
