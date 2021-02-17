using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());

            short highestSnow = 0;
            short highestTime = 0;
            byte highestQuality = 0;

            BigInteger snowballValue = 0;
            BigInteger snowMaxVal = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
               short snowballSnow = short.Parse(Console.ReadLine());
               short snowballTime = short.Parse(Console.ReadLine());
               byte snowballQuality = byte.Parse(Console.ReadLine());

               snowballValue = (BigInteger)Math.Pow((snowballSnow / snowballTime), snowballQuality);
                
                if (snowballValue>snowMaxVal)
                {
                    snowMaxVal = snowballValue;
                    highestSnow = snowballSnow;
                    highestTime = snowballTime;
                    highestQuality = snowballQuality;
                }
            }
            
            Console.WriteLine($"{highestSnow} : {highestTime} = {snowMaxVal} ({highestQuality})");
        }
    }
}
