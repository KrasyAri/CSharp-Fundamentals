using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _24._07_Regular_Expressions_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> furnitures = new List<string>();
            string pattern = @">>(?<furniture>[A-Za-z]+)<<(?<price>\d+\.?\d+)(!)(?<quantity>\d+)\b";
            double totalSum = 0;
            while (input != "Purchase")
            {

                var products = Regex.Match(input, pattern);

                if (products.Success)
                {
                    string furniture = products.Groups["furniture"].Value;
                    double price = double.Parse(products.Groups["price"].Value);
                    double quantity = double.Parse(products.Groups["quantity"].Value);
                    double sum = price * quantity;

                    furnitures.Add(furniture);
                    totalSum += sum;

                }

                input = Console.ReadLine();

            }

            Console.WriteLine("Bought furniture:");

            if (furnitures.Count > 0)
            {
                Console.WriteLine(string.Join("\n", furnitures));

            }

            Console.WriteLine($"Total money spend: {totalSum:f2}");

        }
    }
}
