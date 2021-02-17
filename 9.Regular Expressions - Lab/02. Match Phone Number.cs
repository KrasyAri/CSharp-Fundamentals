using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string phones = Console.ReadLine();

            string pattern = @"\+([359]+)([ -])([2]+)(\2)([0-9]{3})(\2)([0-9]{4})\b";

            MatchCollection phoneMatches = Regex.Matches(phones, pattern);

            var matchedPhones = phoneMatches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));

        }
    }
}
