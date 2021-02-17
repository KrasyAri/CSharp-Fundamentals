using System;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            decimal currentBefore = 0;
            decimal currentAfter = 0;
            decimal sum = 0;
           
            foreach (var item in input)
            {
                char letterBefore = item[0];
                char letterAfter = item[item.Length - 1];
                int number = int.Parse(item.Substring(1, item.Length - 2));

                decimal letterBeforePossition = char.Parse(letterBefore.ToString().ToUpper()) - 64;
                decimal letterAfterPossition = char.Parse(letterAfter.ToString().ToUpper()) - 64;

                if (letterBefore >= 65 && letterBefore <= 90)
                {
                    currentBefore = number / letterBeforePossition;
                }
                else
                {
                    currentBefore = number * letterBeforePossition;
                }

                if (letterAfter >= 65 && letterAfter <= 90)
                {
                    currentAfter = currentBefore - letterAfterPossition;
                }
                else
                {
                    currentAfter = currentBefore + letterAfterPossition;
                }
                sum += currentAfter;

            }

            Console.WriteLine($"{sum:f2}");
            
        }
    }
}
