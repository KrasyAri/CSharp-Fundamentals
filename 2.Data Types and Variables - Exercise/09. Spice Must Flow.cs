using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int countDays = 0;
            int workersConsumed = 0;
            int totalWorkers = 0;

            if (startingYield >= 100)
            {


                while (startingYield >= 100)
                {

                    workersConsumed = startingYield - 26;
                    startingYield -= 10;
                    countDays++;

                    totalWorkers += workersConsumed;
                }
                totalWorkers -= 26;

                Console.WriteLine(countDays);
                Console.WriteLine($"{totalWorkers}");
            }
            else
            {
                Console.WriteLine(countDays);
                Console.WriteLine($"{totalWorkers}");
            }
        }
    }
}
