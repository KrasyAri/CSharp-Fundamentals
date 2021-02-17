using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            decimal result = FactorielOfNum(num1) / FactorielOfNum(num2);

            Console.WriteLine($"{result:f2}");
        }

       
        static decimal FactorielOfNum(int num)
        {
            decimal result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
