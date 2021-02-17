using System;

namespace _20._05_BASIC_SYNTAX__CONDITIONAL_STATEMENTS_AND_LOOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double avarageGrade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {avarageGrade:F2}");

        }
    }
}
