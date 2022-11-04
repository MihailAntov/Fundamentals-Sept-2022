using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Box> boxes = new List<Box>();
            while ((input = Console.ReadLine())!= "end")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                boxes.Add(new Box(cmdArgs[0], new Item(cmdArgs[1], decimal.Parse(cmdArgs[3])), int.Parse(cmdArgs[2])));
            }
            
            foreach(Box box in boxes.OrderByDescending(b=>b.PriceForABox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:f2}");
            }
        }
    }

    public class Item
    {
        public Item(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
    }

    public class Box
    {
        public Box(string serialNumber, Item item, int itemQuantity)
        {
            this.SerialNumber = serialNumber;
            this.Item = item;
            this.ItemQuantity = itemQuantity;
            this.PriceForABox = this.Item.Price * this.ItemQuantity;
        }
        public string SerialNumber { get; private set; }
        public Item Item { get; private set; }
        public int ItemQuantity { get; private set; }
        public decimal PriceForABox { get; private set; }
    }
}
