using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            CheckAllNumberInRange(number);
        }

        static void CheckAllNumberInRange(int num)
        {
            for (int i = 0; i < num; i++)
            {
                if (CheckIfNumIsDivisibleBy8(i) && CheckAtLeastOneOddDigit(i))
                {
                    Console.WriteLine(i);
                }
                else
                {
                    continue;
                }
            }
        }

        static bool CheckIfNumIsDivisibleBy8(int num)
        {

            int currentNum = num;
            int sumOfDigits = 0;

            while (currentNum>0)
            {

                int digit = currentNum % 10;
                sumOfDigits += digit;
                currentNum /= 10;

            }

            if (sumOfDigits % 8 == 0)
            {
                return true;
            }

            return false;
        }

        static bool CheckAtLeastOneOddDigit(int num)
        {
            int currentNum = num;
            while (currentNum > 0)
            {
                int digit = currentNum % 10;
                if (digit % 2 != 0)
                {
                    return true;
                }
                currentNum /= 10;
            }
            return false;

        }
    }
}
