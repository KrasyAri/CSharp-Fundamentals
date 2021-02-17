using System;
using System.Text.RegularExpressions;

namespace _24._07_Regular_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();

            string pattern = @"\b[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+\b";

            MatchCollection machedNames = Regex.Matches(names, pattern);

            foreach (Match name in machedNames)
            {
                Console.Write(name.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
