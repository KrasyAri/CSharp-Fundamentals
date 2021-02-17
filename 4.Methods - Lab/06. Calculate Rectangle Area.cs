using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double high = double.Parse(Console.ReadLine());

            Console.WriteLine(RectanlgeArea(width, high));

        }

        static double RectanlgeArea(double a, double b)
        {
            return a * b;
        }
    }
}
