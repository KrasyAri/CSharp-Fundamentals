using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfComands = int.Parse(Console.ReadLine());

            Dictionary<string, string> usersInfo = new Dictionary<string, string>();

            for (int i = 0; i < numOfComands; i++)
            {
                string act = string.Empty;
                string username = string.Empty;
                string licenseNum = string.Empty;
               
                string input = Console.ReadLine();
                
                string[] commands = input.Split();
                
                if (commands.Length < 3)
                {
                    act = commands[0];
                    username = commands[1];
                }
                else
                {
                    act = commands[0];
                    username = commands[1];
                    licenseNum = commands[2];
                }

                

                if (act == "register")
                {
                    if (usersInfo.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licenseNum}");
                    }
                    else
                    {
                        usersInfo.Add(username, licenseNum);
                        Console.WriteLine($"{username} registered {licenseNum} successfully");
                    }
                }
                else if (act == "unregister")
                {
                    if (!usersInfo.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        usersInfo.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }

            }

            foreach (var pair in usersInfo)
            {
                Console.WriteLine(pair.Key + " => " + pair.Value);
            }
        }
    }

    //public class UsersInfo
    //{
    //    public string Act { get; set; }
    //    public string Username { get; set; }
    //    public string LicenseNum { get; set; }

    //    public UsersInfo (string act, string username, string licenseNum)
    //    {
    //        this.Act = act;
    //        this.Username = username;
    //        this.LicenseNum = licenseNum;
    //    }

    //}
}
