using System;
using System.Collections.Generic;
using System.Linq;

namespace _19._06_Lists_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacityOfEachWagon = int.Parse(Console.ReadLine());

            string command = String.Empty;

            while (true)
            {
                command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split();

                if (tokens[0] == "Add")
                {
                    int newWagon = int.Parse(tokens[1]);
                    wagons.Add(newWagon);
                }
                else
                {
                    int people = int.Parse(tokens[0]);
                    
                    for (int i = 0; i < wagons.Count; i++)
                    {
                       
                        if (wagons[i]+people <= maxCapacityOfEachWagon)
                        {
                            wagons[i] = wagons[i]+people;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                
            }
            Console.WriteLine(string.Join(" ", wagons));
            

        }
    }
}
