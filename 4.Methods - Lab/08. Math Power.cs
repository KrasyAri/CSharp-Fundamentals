using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(NumberToPower(number,power));
        }

        static double NumberToPower (double num, int Pow)
        {
            double result = 1;
            
            for (int i = 1; i <= Pow; i++)
            {
                result *= num;
            }
            
            return result;
        }
    }
}
