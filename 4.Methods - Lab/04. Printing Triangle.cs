﻿using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintTriangle(n);
        }

        static void PrintTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintNumsFrom1(i);
            }
            for (int i = n-1; i > 0;  i--)
            {
                PrintNumsFrom1(i);

            }

        }
        
        static void PrintNumsFrom1(int to)
        {
            for (int i = 1; i <= to; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
       
    }
}
