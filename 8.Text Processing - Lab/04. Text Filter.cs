using System;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var bannWord in bannWords)
            {
                if (text.Contains(bannWord))
                {
                    text = text.Replace(bannWord, new string('*', bannWord.Length));
                }
            }

            Console.WriteLine(text);

        }
    }
}
