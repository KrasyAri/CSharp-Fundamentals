using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = String.Empty;

            while (command != "end")
            {
                command = Console.ReadLine();


                string[] comandIndex = command.Split();

                switch (comandIndex[0])
                {
                    case "Delete":
                        int elementToDelete = int.Parse(comandIndex[1]);
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] == elementToDelete)
                            {
                                numbers.RemoveAt(i);
                                i--;
                            }
                        }
                        break;

                    case "Insert":
                        int elementToInsert = int.Parse(comandIndex[1]);
                        int PositionToInsertElemen = int.Parse(comandIndex[2]);

                        numbers.Insert(PositionToInsertElemen, elementToInsert);
                        break;
                }
               
            }

            int[] numbersArray = numbers.ToArray();
            Console.WriteLine(string.Join(' ', numbersArray));
        }
    }
}
