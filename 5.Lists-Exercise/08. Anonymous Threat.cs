using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();
            string command = String.Empty;

            while (command != "3:1")
            {

                command = Console.ReadLine();

                string[] operations = command.Split().ToArray();

                int startIndexCon = int.Parse(operations[1]);
                int endIndexCon = int.Parse(operations[2]);
                string concatWords = String.Empty;


                switch (operations[0])
                {
                    case "merge":
                        
                       

                        break;



                    //case "divide":
                    //    break;
                }


            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
