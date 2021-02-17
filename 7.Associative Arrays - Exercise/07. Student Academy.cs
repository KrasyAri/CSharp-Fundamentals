using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentsGrades = new Dictionary<string, List<double>>();
            
            
            for (int i = 0; i < n; i++)
            {

                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());


                if (!studentsGrades.ContainsKey(name))
                {
                    studentsGrades.Add(name, new List<double>());
                    studentsGrades[name].Add(grade);
                }
                else
                {
                    studentsGrades[name].Add(grade);
                }

            }

            var avarageResult = new Dictionary<string, double>();

            foreach (var pair in studentsGrades)
            {
                avarageResult.Add(pair.Key, pair.Value.Average());
            }

            foreach (var pair in avarageResult.Where(student => student.Value >= 4.50).OrderByDescending(st => st.Value))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value:f2}");
            }
            
                                        


        }
    }
    
}
