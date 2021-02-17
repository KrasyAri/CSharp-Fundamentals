using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string information = Console.ReadLine();


            string pattern = @"\%(?<name>[A-Z][a-z]+)\%([^\%\$\%.]*)<(?<product>\w+)>([^\%\$\%\.]*)\|(?<count>[0-9]+)\|([^\%\$\%\.0-9]*)(?<price>[0-9]+\.?[0-9]*)\$";
                           //@"\%(?<name>[A-Z][a-z]+)\%([^\%\$\|\.]*)<(?<product>[\w]*)>([^\%\$\|\.]*)\|(?<count>[0-9]*)\|([^\%\$\|\.0-9]*)(?<price>[\w\.]*)\$"
            double totalIncome = 0;

            while (information != "end of shift")
            {

                var match = Regex.Match(information, pattern);
                

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    double count = double.Parse(match.Groups["count"].Value);
                    double totalPrice = double.Parse(match.Groups["price"].Value) * count;

                    Console.WriteLine($"{name}: {product} - {totalPrice:f2}");
                    totalIncome += totalPrice;
                }

                information = Console.ReadLine();
            }

          Console.WriteLine($"Total income: {totalIncome:f2}");


        }
    }
}
