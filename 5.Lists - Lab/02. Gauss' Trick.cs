using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            Console.WriteLine(string.Join(" ",SumFirstAndLast(numbers)));
        }

        static List<int> SumFirstAndLast(List<int> nums)
        {
            List<int> result = new List<int>();
           
            for (int i = 0; i < nums.Count/2; i++)
            {
                result.Add(nums[i] + nums[nums.Count - i - 1]);
              
            }

            if (nums.Count % 2 != 0)
            {
                result.Add(nums[nums.Count / 2]);
            }

            return result;
        }
    }
}
