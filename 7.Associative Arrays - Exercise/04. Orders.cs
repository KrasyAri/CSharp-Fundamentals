using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, List<double>> productCatalogue = new Dictionary<string, List<double>>();
            List<double> tempValues = new List<double>();
            List<double> values = new List<double>();
            double quantity = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "buy")
                {
                    break;
                }

                string[] productInfo = input.Split();

                string product = productInfo[0];
                double price = double.Parse(productInfo[1]);
                double currentQuantity = double.Parse(productInfo[2]);


                if (!productCatalogue.ContainsKey(product))
                {
                     
                    values.Add(price);
                    values.Add(currentQuantity);
                    productCatalogue.Add(product, new List<double>(values));
                }
                else
                {
                    
                    quantity += currentQuantity;
                    values.Clear();
                    values.Add(price);
                    values.Add(quantity);
                    
                }
                
            }
            foreach (var pair in productCatalogue)
            {
                Console.WriteLine(pair.Key + " -> " + string.Join(" ",values));
            }
        }

       
    }
}
