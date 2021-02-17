using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int powerN = int.Parse(Console.ReadLine());
            int distanceM = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());

            int pokeCount = 0;
            int originalN = powerN;

            while (distanceM<=powerN)
            {
                powerN -= distanceM;
                pokeCount++;

                if (powerN == originalN/2)
                {
                    if (exhaustionFactorY>0)
                    {
                         powerN /= exhaustionFactorY;
                         continue;  
                    }
                }
            }

            Console.WriteLine(powerN);
            Console.WriteLine(pokeCount);
        }
    }
}
