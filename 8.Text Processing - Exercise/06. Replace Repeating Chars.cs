using System;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < text.Length-1; i++)
            {
                if (text[i] == text[i+1])
                {
                    continue;
                }
                else
                {
                    sb.Append(text[i]);
                }
                
            }
            sb.Append(text[text.Length - 1]);
            Console.WriteLine(sb);
        }
    }
}
