using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int number = 0;
            bool isSpecial = false;

            for (int i = 1; i <= n; i++)
            {
                int digitSum = 0;
                number = i;

                while (number > 0)
                {
                    digitSum += number % 10;
                    number /= 10;
                }
                
                isSpecial = (digitSum == 5) || (digitSum == 7) || (digitSum == 11);
                
                Console.WriteLine($"{i} -> {isSpecial}");
               
          
            }

        }
    }
}
