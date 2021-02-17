using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._07_Associative_Arrays_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {

                char symbol = text[i];
                if (symbol == ' ')
                {
                    continue;
                }
                else if (charCount.ContainsKey(symbol))
                {
                    charCount[symbol]++;
                }
                else
                {
                    charCount.Add(symbol, 1);
                }

            }

            foreach (var pair in charCount)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }
    }
}
