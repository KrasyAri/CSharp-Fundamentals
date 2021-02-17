using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            CharsBetweenTwo(first, second);
        }

        static void CharsBetweenTwo(char a, char b)
        {
            if (a < b)
            {
                for (int i = a + 1; i < b; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = b +1; i < a; i++)
                {
                    Console.Write((char)i + " ");
                }
            }

        }
    }
}
