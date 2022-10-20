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
            
            foreach(Box box in boxes.OrderByDescending(b=>b.priceForABox))
            {
                Console.WriteLine(box.serialNumber);
                Console.WriteLine($"-- {box.item.name} - ${box.item.Price:f2}: {box.itemQuantity}");
                Console.WriteLine($"-- ${box.priceForABox:f2}");
            }
        }
    }

    public class Item
    {
        public Item(string _name, decimal _price)
        {
            name = _name;
            Price = _price;
        }
        public string name;
        public decimal Price;
    }

    public class Box
    {
        public Box(string _serialNumber, Item _item, int _itemQuantity)
        {
            serialNumber = _serialNumber;
            item = _item;
            itemQuantity = _itemQuantity;
            priceForABox = item.Price * itemQuantity;
        }
        public string serialNumber;
        public Item item;
        public int itemQuantity;
        public decimal priceForABox;
    }
}
