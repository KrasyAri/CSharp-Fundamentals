using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(new char [] { ' ', ','},StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> namesAndKms = new Dictionary<string, int>();

            string input = Console.ReadLine();
            string namePattern = @"[A-Za-z]";
            string digitsPattern = @"\d";


            while (input != "end of race")
            {

                var nameMatch = Regex.Matches(input, namePattern);
                var kmsMatch = Regex.Matches(input, digitsPattern);

                var name = string.Concat(nameMatch);
                var sumOfKms = kmsMatch.Select(x => int.Parse(x.Value)).Sum();

                if (participants.Contains(name))
                {
                    if (namesAndKms.ContainsKey(name))
                    {
                        namesAndKms[name] += sumOfKms;
                    }
                    else
                    {
                        namesAndKms.Add(name,sumOfKms);
                    }
                }

                input = Console.ReadLine();
            }

            var sorted = namesAndKms.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();

            Console.WriteLine($"1st place: {sorted[0]}");
            Console.WriteLine($"2nd place: {sorted[1]}");
            Console.WriteLine($"3rd place: {sorted[2]}");
        }
    }
}
