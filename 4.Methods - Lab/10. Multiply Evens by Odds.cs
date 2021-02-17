using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            num = Math.Abs(num);

            Console.WriteLine(CalculateOEvenSum(num)*CalculateOddSum(num));
        }
       
        static int CalculateOddSum(int number)
        {
            int sumOdd = 0;
            while (number > 0)
            {
                int currentNum = number % 10;
                
                if (currentNum % 2 != 0)
                {
                    sumOdd += currentNum;
                }
                number = number/10;
            }
            return sumOdd;
        }
        static int CalculateOEvenSum(int number)
        {
            int sumEven = 0;
            while (number > 0)
            {
                int currentNum = number % 10;

                if (currentNum % 2 == 0)
                {
                    sumEven += currentNum;
                }
                number = number / 10;
            }
            return sumEven;
        }
       
    }
}
