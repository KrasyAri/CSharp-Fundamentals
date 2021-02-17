using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Team> teams = new List<Team>();

            int numberOfTeams = int.Parse(Console.ReadLine());


            for (int i = 0; i < numberOfTeams; i++)
            {
                var info = Console.ReadLine().Split("-").ToArray();

                string creator = info[0];
                string teamName = info[1];
                //create team

                if (teams.Any(x => x.UserName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                else if (teams.Any(x => x.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                Team team = new Team(teamName, creator);
                teams.Add(team);
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }
            string command = String.Empty;

            while ((command = Console.ReadLine()) != "end of assignment")
            {

                var info = command.Split("->").ToArray();

                string userName = info[0];
                string teamName = info[1];
                //add person to team

                if (!teams.Any(x => x.UserName == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }
                if (teams.Any(x => x.PeopleJoint.Contains(userName) || teams.Any(x => x.Creator == userName && x.UserName == teamName)))
                {
                    Console.WriteLine($"Member {userName} cannot join team {teamName}!");
                    continue;
                }
         

                int index = teams.FindIndex(x => x.UserName == teamName);
                teams[index].PeopleJoint.Add(userName);
               
            }

            var teamsToBeDisbounded = teams
                .FindAll(x => x.PeopleJoint.Count == 0)
                .OrderBy(x => x.UserName)
                .ToList();

            foreach (var team in teams.Where(x => x.PeopleJoint.Count > 0)
                .OrderByDescending(x => x.PeopleJoint.Count)
                .ThenBy(x => x.UserName))
            {
                Console.WriteLine(team.ToString());
            }

            //var validTeams = teams.FindAll(x => x.PeopleJoint.Count > 0).OrderBy(x => x.UserName).ToList();

            //Console.WriteLine(string.Join(Environment.NewLine,validTeams
            //    .OrderByDescending(x => x.PeopleJoint.Count)
            //    .ThenBy(x => x.UserName)));

            Console.WriteLine("Teams to disband: ");
            foreach (var item in teamsToBeDisbounded)
            {
                Console.WriteLine(item.UserName);

            }
        }
    }

    public class Team
    {
        public string UserName { get; set; }
        public string Creator { get; set; }

        public List<string> PeopleJoint;

        public Team(string userName, string creator)
        {
            this.UserName = userName;
            this.Creator = creator;
            PeopleJoint = new List<string>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(UserName);
            sb.AppendLine("- " + Creator);

            foreach (var member in PeopleJoint.OrderBy(x => x))
            {
                sb.AppendLine("-- " + member);
            }
            return sb.ToString().TrimEnd();
        }
    }
}
