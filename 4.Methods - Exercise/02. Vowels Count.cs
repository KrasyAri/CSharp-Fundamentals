using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            VowelsCount(input);
        }

        static void VowelsCount(string input)
        {

            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {

                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u' ||
                    input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'O' || input[i] == 'U')
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
