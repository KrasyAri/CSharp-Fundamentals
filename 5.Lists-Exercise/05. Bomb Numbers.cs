using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bombNumAndPower = Console.ReadLine().Split().Select(int.Parse).ToList();

            int bombNumber = bombNumAndPower[0];
            int power = bombNumAndPower[1];
            int bombIndex = numbers.IndexOf(bombNumber);

            while (bombIndex != -1)
            {
                int leftNumb = bombIndex - power;
                int rightNum = bombIndex + power;

                if (leftNumb < 0)
                {
                    leftNumb = 0;
                }
                if (rightNum > numbers.Count-1)
                {
                    rightNum = numbers.Count-1;
                }

                numbers.RemoveRange(leftNumb, rightNum - leftNumb + 1);

                bombIndex = numbers.IndexOf(bombNumber);
            }

            int sum = numbers.Sum();

            Console.WriteLine(sum);
        }
    }
}
