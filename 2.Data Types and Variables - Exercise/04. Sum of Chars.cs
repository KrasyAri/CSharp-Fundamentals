﻿using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                char letters = char.Parse(Console.ReadLine());
                sum += letters;
                
            }
           
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
