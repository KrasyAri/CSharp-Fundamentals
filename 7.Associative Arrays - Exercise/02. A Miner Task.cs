using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            Dictionary<string, int> collection = new Dictionary<string, int>();

            while (input != "stop")
            {
                string resource = input;
                int quantity = int.Parse(Console.ReadLine());
                
                if (collection.ContainsKey(resource))
                {
                    collection[resource] += quantity;
                }
                else
                {
                    collection.Add(resource, quantity);
                }
                input = Console.ReadLine();
            }

            foreach (var pair in collection)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }
    }
}
