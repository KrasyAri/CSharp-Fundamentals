using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = String.Empty;
            bool chanded = false;

            while (true)
            {
                command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split();

                switch (tokens[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        numbers.Add(numberToAdd);
                        break;

                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        numbers.Remove(numberToRemove);
                        break;

                    case "RemoveAt":
                        int removeIndex = int.Parse(tokens[1]);
                        numbers.RemoveAt(removeIndex);
                        break;

                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        break;

                    case "Contains":
                        int checkIfContains = int.Parse(tokens[1]);
                        numbers.Contains(checkIfContains);
                        if (numbers.Contains(checkIfContains))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;

                    case "Filter":

                        string condition = tokens[1];
                        int number = int.Parse(tokens[2]);
                        if (tokens[1] == "<")
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] < number)
                                {
                                    Console.Write($"{numbers[i] + " "}");

                                }
                            }
                            Console.WriteLine();
                        }

                        if (tokens[1] == ">")
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] > number)
                                {
                                    Console.Write($"{numbers[i] + " "}");

                                }
                            }
                            Console.WriteLine();

                        }

                        if (tokens[1] == "<=")
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] <= number)
                                {
                                    Console.Write($"{numbers[i] + " "}");

                                }
                            }
                            Console.WriteLine();

                        }

                        if (tokens[1] == ">=")
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] >= number)
                                {
                                    Console.Write($"{numbers[i] + " "}");

                                }
                            }
                            Console.WriteLine();

                        }
                        break;

                    case "PrintEven":

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                Console.Write($"{numbers[i] + " "}");

                            }

                        }
                        Console.WriteLine();
                        break;

                    case "PrintOdd":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 != 0)
                            {
                                Console.Write($"{numbers[i] + " "}");

                            }
                        }
                        Console.WriteLine();
                        break;

                    case "GetSum":
                        int sum = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sum += numbers[i];
                        }
                        Console.WriteLine(sum);
                        break;
                }
                if (tokens[0] == "Add" || tokens[0] == "Remove" || tokens[0] == "RemoveAt" || tokens[0] == "Insert")
                {
                    chanded = true;
                }


            }
            if (chanded)
            {
                Console.WriteLine();
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
