using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            RepeatedString(input, n);
        }

        static void RepeatedString (string input, int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(input);
            }
            Console.WriteLine();
        }
    }
}
