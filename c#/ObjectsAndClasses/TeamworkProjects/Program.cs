using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int numTeams = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();
            //user - creator of the team
            //team
            string teamCreator;
            string teamName;

            for (int i = 0; i < numTeams; i++)
            {
                string[] input = Console.ReadLine().Split('-').ToArray();
                teamCreator = input[0];
                teamName = input[1];

                if(teams.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else
                {
                    if(teams.Any(x => x.Name == teamCreator))
                    {
                        Console.WriteLine($"{teamCreator} cannot create another team!");
                    }
                    else
                    {
                        Team team = new Team();
                        team.Name = teamCreator;
                        team.TeamName = teamName;
                        List<string> members = new List<string>();
                        // members.Add(teamCreator); - this will break the output, regardless that he is trying to join his own team.
                        team.TeamMembers = members;

                        teams.Add(team); // storing the created teams, with no name or creator duplications

                        Console.WriteLine($"Team {teamName} has been created by {teamCreator}!");
                    }
                }
            }


            //Filling the teams
            string command = Console.ReadLine();
            //teamName;
            string member;

            while(command != "end of assignment")
            {
                string[] input = command.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                member = input[0];
                teamName = input[1];

                if (!teams.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if(teams.Any(x => x.TeamMembers.Contains(member)) || teams.Any(x => x.Name == member))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                }
                else
                {
                    foreach (var squad in teams.Where(x => x.TeamName == teamName))
                    {
                        squad.TeamMembers.Add(member);
                    }
                        
                }
                command = Console.ReadLine();
            }


            foreach (var team in teams.Where(x => x.TeamMembers.Count != 0).OrderByDescending(x => x.TeamMembers.Count).ThenBy(x => x.Name))
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.Name}");
                foreach (var teamMember in team.TeamMembers.OrderBy(x=> x))
                {
                    Console.WriteLine($"-- {teamMember}");
                }                
            }

            Console.WriteLine($"Teams to disband:");
            foreach (var team in teams.Where(x=> x.TeamMembers.Count==0).OrderBy(x=>x.Name))
            {
                Console.WriteLine($"-- {team.Name}");

            }


        }
    }
    public class Team
    {
        public List<string> TeamMembers { get; set; }
        public string Name { get; set; }
        public string TeamName { get; set; }

    }
}
