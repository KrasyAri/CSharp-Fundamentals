using System;

namespace _03._Vacation_Fund
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupNum = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double price = 0;
            double totalPrice = 0;

            if (typeOfGroup == "Students")
            {

                switch (dayOfWeek)
                {
                    case "Friday":
                        price = 8.45;
                        break;
                    case "Saturday":
                        price = 9.80;
                        break;
                    case "Sunday":
                        price = 10.46;
                        break;
                }

                 totalPrice = groupNum * price;

                if (groupNum >= 30)
                {
                    totalPrice = totalPrice - totalPrice * 0.15;
                }
            }

            else if (typeOfGroup == "Business")
            {

                switch (dayOfWeek)
                {
                    case "Friday":
                        price = 10.90;
                        break;
                    case "Saturday":
                        price = 15.60;
                        break;
                    case "Sunday":
                        price = 16.00;
                        break;
                }
                
                 totalPrice = groupNum * price;

                if (groupNum >= 100)
                {
                    totalPrice = totalPrice - price*10;
                }

            }

            else if (typeOfGroup == "Regular")
            {

                switch (dayOfWeek)
                {
                    case "Friday":
                        price = 15.00;
                        break;
                    case "Saturday":
                        price = 20.00;
                        break;
                    case "Sunday":
                        price = 22.50;
                        break;
                }

                 totalPrice = groupNum * price;

                if (groupNum >= 10 && groupNum <=20)
                {
                    totalPrice = totalPrice - totalPrice * 0.05;
                }
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");

        }
    }
}
