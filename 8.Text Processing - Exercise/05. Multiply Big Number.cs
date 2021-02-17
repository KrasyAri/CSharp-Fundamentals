using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine().TrimStart('0');
            int multiplier = int.Parse(Console.ReadLine());

            
            if (multiplier == 0 || bigNumber == "0")
            {
                Console.WriteLine(0);
                return;
            }
            

            StringBuilder sb = new StringBuilder();
            int oneInMind = 0;

            for (int i = bigNumber.Length-1; i >= 0; i--)
            {

                int result = (int.Parse)(bigNumber[i].ToString()) * multiplier + oneInMind;
                oneInMind = 0;

                if (result > 9)
                {
                    oneInMind = result / 10;
                    result = result % 10;
                }

                sb.Append(result);
                
            }

            if (oneInMind != 0)
            {
                sb.Append(oneInMind);
            }


            StringBuilder finalResult = new StringBuilder();

            for (int i = sb.Length-1; i >= 0; i--)
            {
                finalResult.Append(sb[i]);
            }

            Console.WriteLine(finalResult);
        }
    }
}
