using System;

namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceOfLighsaber = double.Parse(Console.ReadLine());
            double priceOfRobe = double.Parse(Console.ReadLine());
            double priceOfBelt = double.Parse(Console.ReadLine());

            double total = (Math.Ceiling(1.10 * students)) * priceOfLighsaber +
                            students * priceOfRobe +
                            (students - (students / 6)) * priceOfBelt;
            if(total <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {total - money:f2}lv more.");
            }
        }
    }
}
