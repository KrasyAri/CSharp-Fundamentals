using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            Calculation(firstNum, operation, secondNum);
        }

        static void Calculation(double num1, char operation, double num2)
        {
            double result = 0;
            switch (operation)
            {
                case '/':
                    result = num1 / num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
