using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{n} X {end} = {n * end}");
                end++;
            }
            while (end <= 10) ;
        }
    }
}
