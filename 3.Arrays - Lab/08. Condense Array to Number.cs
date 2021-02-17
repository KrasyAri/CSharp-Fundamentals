using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int currentSum = 0;
            int sum = 0;

            for (int i = 0; i < nums.Length-1; i++)
            {

                currentSum = nums[i] + nums[i + 1];
                sum += currentSum;
            }
            Console.WriteLine(sum);
        }
    }
}
