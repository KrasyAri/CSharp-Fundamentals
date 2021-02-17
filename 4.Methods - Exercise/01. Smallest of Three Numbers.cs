using System;

namespace _12._06___Methods_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(CompareThreeNumbers(num1, num2, num3));
        }

        static int CompareThreeNumbers(int number1, int number2, int number3)
        {
            int minValue = int.MaxValue;
            for (int i = 1; i <= 3; i++)
            {
                if (number1 < minValue)
                {
                    minValue = number1;
                }
                else if (number2<minValue)
                {
                    minValue = number2;
                }
                else if(number3 < minValue)
                {
                    minValue = number3;
                }
            }
           
            return minValue;
        }
    }
}
