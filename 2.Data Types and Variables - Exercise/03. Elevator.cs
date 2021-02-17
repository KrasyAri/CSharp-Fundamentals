using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double rounds = Math.Ceiling(numOfPeople / (double)capacity);

            Console.WriteLine(rounds);
        }
    }
}
