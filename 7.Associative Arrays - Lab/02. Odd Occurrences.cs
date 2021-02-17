using System;
using System.Collections.Generic;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string wordLowerCase = word.ToLower();

                if (counts.ContainsKey(wordLowerCase))
                {
                    counts[wordLowerCase]++;
                }
                else
                {
                    counts.Add(wordLowerCase, 1);
                }
            }

            foreach (var item in counts)
            {
                if (item.Value % 2 == 1)
                {
                    Console.Write(item.Key + " ");
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
