using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(Console.ReadLine());

            string decryptCodePattern = @"[sStTaArR]";
            string messagePattern = @"^[^@\-!:>]*@(?<name>[a-zA-z]+)[^@\-!:>]*:[^@\-!:>]*?(?<population>\d+)[^@\-!:>]*![^@\-!:>]*(?<action>[AD])![^@\-!:>]*->(?<soldiers>\d+)[^@\-!:>]*$";
            
            List<string> attaked = new List<string>();
            List<string> destroyed = new List<string>();

            for (int i = 0; i < numberOfMessages; i++)
            {
                string message = Console.ReadLine();

                var decryptCodeMatch = Regex.Matches(message,decryptCodePattern);
                int count = decryptCodeMatch.Count;

                string decryptedMessage = String.Empty;

                foreach (var character in message)
                {
                    decryptedMessage += (char)(character - count);
                }

                var messageMatch = Regex.Match(decryptedMessage, messagePattern);

                if (messageMatch.Success)
                {
                    if (messageMatch.Groups["action"].Value == "A")
                    {
                        attaked.Add(messageMatch.Groups["name"].Value);
                    }
                    else
                    {
                        destroyed.Add(messageMatch.Groups["name"].Value);
                    }

                }
                
            }

            attaked.Sort();
            destroyed.Sort();

            Console.WriteLine($"Attacked planets: {attaked.Count}");
            if (attaked.Count>0)
            {
                Console.WriteLine($"-> {string.Join("\n" + "-> ", attaked)}");
            }
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            if (destroyed.Count>0)
            {
                Console.WriteLine($"-> {string.Join("\n"+"-> ", destroyed)}");
            }
        }
    }
}
