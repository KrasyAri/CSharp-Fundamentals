using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            MiddleChar(input);
        }

        static void MiddleChar(string text)
        {
            
           int middle = (text.Length - 1) / 2;

            if (text.Length % 2 == 0)
            {
                Console.WriteLine($"{text[middle]}{text[middle+1]}");
            }
            else
            {
                Console.WriteLine(text[middle]);
            }
            
        }
    }
}
