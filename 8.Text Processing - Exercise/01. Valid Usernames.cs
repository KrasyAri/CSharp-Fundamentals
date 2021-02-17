using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            var validUsernames = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                string current = input[i];

                if (current.Length>=3 && current.Length<=16)
                {
                    bool isValid = true;
                    for (int j = 0; j < current.Length; j++)
                    {
                        if (!(char.IsLetterOrDigit(current[j]) || current[j] == '-' || current[j] == '_'))
                        {
                            isValid = false;
                        }
                    }

                    if (isValid)
                    {
                        validUsernames.Add(current);
                    }
                }
            }

            Console.WriteLine(string.Join("\n", validUsernames));
            
        }
    }
}
