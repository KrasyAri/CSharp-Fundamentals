using System;

namespace _10._06___Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSignOfNum(n);
        }

        static void PrintSignOfNum(int num)
        {
            if (num>0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num<0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else if (num == 0)
            {
                Console.WriteLine($"The number {num} is zero.");
            }
           
        }
    }
}
