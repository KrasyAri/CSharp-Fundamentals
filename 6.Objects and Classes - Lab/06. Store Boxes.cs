using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> productsProp = new List<Box>();
            string line = Console.ReadLine();

            while (line != "end")
            {

                string[] tokens = line.Split();
                string serialNumber = tokens[0];
                string itemName = tokens[1];
                int itemQuantity = int.Parse(tokens[2]);
                decimal itemPrice = decimal.Parse(tokens[3]);

                //Item item = new Item()
                //{
                //    Name = itemName,
                //    Price = itemPrice
                //};

                Box box = new Box()
                {
                    SerialNumber = serialNumber,
                    ItemName = itemName,
                    ItemPrice = itemPrice,
                    ItemQuantity = itemQuantity,
                    PriceForBox = itemQuantity * itemPrice

                };

                productsProp.Add(box);
                line = Console.ReadLine();
            }

            List<Box> sortedBox = productsProp.OrderBy(boxes => boxes.PriceForBox).ToList();
            sortedBox.Reverse();

            foreach (Box box in sortedBox)
            {
                

                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.ItemName} - ${ box.ItemPrice:f2}: { box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:f2}");

            }
        }
    }

    //public class Item
    //{
    //    public string Name { get; set; }
    //    public decimal Price { get; set; }
    //}

    public class Box
    {
      
        public string SerialNumber { get; set; }
        public string ItemName { get; set; }
        public decimal ItemPrice { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForBox { get; set; }
    }
}
