using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            Calculation(operation, firstNum, secondNum);
        }

        static void Calculation(string oper, int a, int b)
        {
            if (oper == "add")
            {
                Console.WriteLine(a + b);
            }
            else if (oper == "multiply")
            {
                Console.WriteLine(a * b);
            }
            else if (oper == "subtract")
            {
                Console.WriteLine(a - b);
            }
            else if (oper == "divide")
            {
                Console.WriteLine(a / b);
            }
        }
    }
}
