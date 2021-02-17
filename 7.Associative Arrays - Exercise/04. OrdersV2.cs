using System;
using System.Collections.Generic;

namespace _04._Orders_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, Product> productsInfo = new Dictionary<string, Product>();
            
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "buy")
                {
                    break;
                }
                string[] splittedInput = input.Split();

                string name = splittedInput[0];
                double price = double.Parse(splittedInput[1]);
                int quantity = int.Parse(splittedInput[2]);

               
                Product product = new Product(name, price, quantity);

                if (!productsInfo.ContainsKey(name))
                {
                    productsInfo.Add(name, product);
                }
                else
                {
                    productsInfo[name].Price = price;
                    productsInfo[name].Quantity += quantity;
                }
                
            }

            foreach (var pair in productsInfo)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value.Price*pair.Value.Quantity:f2}");
            }
        }
    }

    class Product
    {
        string name;
        double price;
        int quantity;

        public Product(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
    }
}
