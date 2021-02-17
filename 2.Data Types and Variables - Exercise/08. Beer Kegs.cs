using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            float MaxVol = float.MinValue;
            string biggestKeg = string.Empty;

            for (int i = 0; i < n; i++)
            {

                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int high = int.Parse(Console.ReadLine());

                float volume = (float)(Math.PI * Math.Pow(radius,2) * high);

                if (volume >= MaxVol)
                {
                    MaxVol = volume;
                    biggestKeg = model;
                }
            }

            Console.WriteLine(biggestKeg);

        }
    }
}
