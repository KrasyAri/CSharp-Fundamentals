using System;

namespace _27._05_Data_Types_and_Variables_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            float kilometers = meters*0.001f;

            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
