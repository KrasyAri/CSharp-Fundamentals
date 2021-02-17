using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] commandArr = input.Split();

                if (commandArr[0] == "Add")
                {
                    int numberToAdd = int.Parse(commandArr[1]);

                    numbers.Add(numberToAdd);
                }
                
                else if (commandArr[0] == "Insert")
                {
                    int numberToIns = int.Parse(commandArr[1]);
                    int IndexToIns = int.Parse(commandArr[2]);
                    if (IndexToIns>=0 && IndexToIns<numbers.Count)
                    {
                        numbers.Insert(IndexToIns, numberToIns); 
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }

                }
               
                else if (commandArr[0] == "Remove")
                {
                    int IndexToRem = int.Parse(commandArr[1]);

                    if (IndexToRem >= 0 && IndexToRem < numbers.Count)
                    {
                        numbers.RemoveAt(IndexToRem);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }

                }
              
                else if (commandArr[0] == "Shift" && commandArr[1] == "left")
                {
                    int countL = int.Parse(commandArr[2]);

                    for (int i = 0; i < countL; i++)
                    {
                        int firstNum = numbers[0];
                        numbers.Add(firstNum); 
                        numbers.RemoveAt(0);
                        
                    }
                }
               
                else if (commandArr[0] == "Shift" && commandArr[1] == "right")
                {
                    int countR = int.Parse(commandArr[2]);

                    for (int i = 0; i < countR; i++)
                    {
                        int lastNum = numbers[numbers.Count - 1];
                        numbers.Insert(0, lastNum);
                        numbers.RemoveAt(numbers.Count - 1);

                    }

                }
               
                input = Console.ReadLine();
            
            }
            
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
