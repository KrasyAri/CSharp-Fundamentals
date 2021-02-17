using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List <Students> students = new List<Students>();

            for (int i = 0; i < n; i++)
            {
                string[] studentInfo = Console.ReadLine().Split().ToArray();

                string firstName = studentInfo[0];
                string secondName = studentInfo[1];
                decimal grade = decimal.Parse(studentInfo[2]);

                Students student = new Students();

                student.FirstName = firstName;
                student.SecondName = secondName;
                student.Grade = grade;

                students.Add(student);

            }

            students = students.OrderByDescending(x => x.Grade).ToList();

            foreach (Students student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.SecondName}: {student.Grade}");
            }
        }
    }

    public class Students
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public decimal Grade { get; set; }


    }
}
