using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            List<string> evenWords = words.Where(word => word.Length % 2 == 0).ToList();

            Console.WriteLine(string.Join("\n",evenWords));
        }
    }
}
