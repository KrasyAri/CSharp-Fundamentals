using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, int> collection = new Dictionary<string, int>();
            collection.Add("shards", 0);
            collection.Add("motes", 0);
            collection.Add("fragments", 0);
            Dictionary<string, int> junk = new Dictionary<string, int>();

            bool isFound = false;
           
            while (!isFound)
            {
                string[] input = Console.ReadLine().Split();
                for (int i = 0; i < input.Length; i += 2)
                {
                    string key = input[i + 1].ToLower();
                    int value = int.Parse(input[i]);

                    if (collection.ContainsKey(key))
                    {
                        collection[key] += value;

                        if (collection[key] >= 250)
                        {
                            isFound = true;
                            string legendaryItem = FoundLegendaryItem(key);
                            Console.WriteLine($"{legendaryItem} obtained!");
                            collection[key] -= 250;
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(key))
                        {
                            junk[key] = 0;
                        }

                        junk[key] += value;
                    }

                }
            }

            collection = collection.OrderByDescending(n => n.Value).ThenBy(n => n.Key).ToDictionary(a => a.Key.ToLower(),b => b.Value);
            junk = junk.OrderBy(n => n.Key.ToLower()).ToDictionary(a => a.Key.ToLower(), b => b.Value);

            foreach (var pair in collection)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value);
            }

            foreach (var pair2 in junk)
            {
                Console.WriteLine(pair2.Key + ": " + pair2.Value);
            }
           
        }

        private static string FoundLegendaryItem(string name)
        {
            string legendaryItem = string.Empty;
            switch (name)
            {
                case "shards":
                    legendaryItem = "Shadowmourne";
                    break;
                case "motes":
                    legendaryItem = "Dragonwrath";
                    break;
                case "fragments":
                    legendaryItem = "Valanyr";
                    break;

            }

            return legendaryItem;
        }
    }
}
