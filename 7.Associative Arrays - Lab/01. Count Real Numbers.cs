using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._07_Associative_Arrays_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                {
                    counts.Add(number, 1);
                }
            }

            foreach (var pair in counts)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }
    }
}
