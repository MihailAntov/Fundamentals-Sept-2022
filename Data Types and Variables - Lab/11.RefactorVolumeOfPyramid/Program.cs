using System;

namespace _11.RefactorVolumeOfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            double length =double.Parse(Console.ReadLine());
           
            
            double width = double.Parse(Console.ReadLine());
            
            
            double height = double.Parse(Console.ReadLine());


            double volume = (length * width * height) / 3;
            //below is to match the unit test requirements in judge
            Console.Write("Length: Width: Height: ");
            Console.WriteLine($"Pyramid Volume: {volume:f2}");
        }
    }
}
