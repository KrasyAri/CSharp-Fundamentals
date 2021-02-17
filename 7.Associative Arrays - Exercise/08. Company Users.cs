using System;
using System.Collections.Generic;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> companyEmployee = new SortedDictionary<string, List<string>>();


            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                string[] input = command.Split(" -> ");

                string companyName = input[0];
                string employeeId = input[1];

                if (!companyEmployee.ContainsKey(companyName))
                {
                    companyEmployee.Add(companyName, new List<string>());
                    companyEmployee[companyName].Add(employeeId);
                }
                else
                {
                    if (!companyEmployee[companyName].Contains(employeeId))
                    {
                        companyEmployee[companyName].Add(employeeId);
                    }
                    else
                    {
                        continue;
                    }
                    
                }
            }

            foreach (var pair in companyEmployee)
            {
                Console.WriteLine($"{pair.Key}\n-- {string.Join("\n-- ", pair.Value)}");
            }


        }
    }
}
