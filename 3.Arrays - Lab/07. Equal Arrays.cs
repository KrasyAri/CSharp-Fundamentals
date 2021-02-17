using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            int diference = 0;
            bool arrayIdentical = true;

            for (int i = 0; i < array1.Length; i++)
            {
                sum += array1[i];

                if (array1[i]!=array2[i])
                {
                    diference = i;
                    arrayIdentical = false;
                    break;
                } 
                
            }

            if (arrayIdentical==true)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}"); 
            }
            else if (arrayIdentical==false)
            {
               Console.WriteLine($"Arrays are not identical. Found difference at {diference} index");
            }
            
        }
    }
}
