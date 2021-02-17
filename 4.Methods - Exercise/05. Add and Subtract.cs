using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int result = SumOfInt(num1, num2) - num3;

            Console.WriteLine(result);
        }

        static int SumOfInt(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

       
    }
}
