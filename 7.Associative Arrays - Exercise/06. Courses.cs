using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();


            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                string[] info = input.Split(" : ");

                string course = info[0];
                string name = info[1];
                
                if (!courses.ContainsKey(course))
                {

                    courses.Add(course, new List<string>());
                    courses[course].Add(name);
                }
                else
                {

                    courses[course].Add(name);
                }
            }

            foreach (var pair in courses.OrderByDescending(st => st.Value.Count))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value.Count}");
                Console.WriteLine($"-- {string.Join("\n-- ", pair.Value.OrderBy(v => v))}");
            }
          
        }
    }
}
