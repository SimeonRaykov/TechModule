using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamWorkProjects
{
    class TeamWorkProjects
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> teamsDictionary
                = new Dictionary<string, Dictionary<string, int>>();

            Dictionary<string, string> creatorDictionary = new Dictionary<string, string>();

            List<string> alreadyCreated = new List<string>();

            List<string> isMember = new List<string>();

            string input = Console.ReadLine();

            int count = 0;

            while (input != "end of assignment")
            {
                if (input.Contains("-") && input.Contains("->") == false)
                {
                    var tokens = input.Split("-", StringSplitOptions.RemoveEmptyEntries);
                    var user = tokens[0];
                    var team = tokens[1];

                    if (teamsDictionary.ContainsKey(team) == false)
                    {
                        if (alreadyCreated.Contains(user) == false)
                        {
                            if (count < n)
                            {
                                teamsDictionary.Add(team, new Dictionary<string, int>());
                                Console.WriteLine($"Team {team} has been created by {user}!");
                                isMember.Add(user);
                                if (creatorDictionary.ContainsKey(team) == false)
                                {
                                    creatorDictionary.Add(team, "");
                                }

                                creatorDictionary[team] = user;

                                alreadyCreated.Add(user);
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{user} cannot create another team!");
                        }
                    }
                    else if (teamsDictionary.ContainsKey(team))
                    {
                        Console.WriteLine($"Team {team} was already created!");
                    }

                }
                else if (input.Contains("->"))
                {
                    var tokens = input.Split("->", StringSplitOptions.RemoveEmptyEntries);
                    var user = tokens[0];
                    var teamToJoin = tokens[1];

                    if (teamsDictionary.ContainsKey(teamToJoin) == false)
                    {
                        Console.WriteLine($"Team {teamToJoin} does not exist!");
                    }
                    else if (teamsDictionary.ContainsKey(teamToJoin))
                    {
                        if (isMember.Contains(user) == false)
                        {
                            teamsDictionary[teamToJoin].Add(user, 0);
                            teamsDictionary[teamToJoin][user] += 1;

                        }
                        else
                        {
                            Console.WriteLine($"Member {user} cannot join team {teamToJoin}");
                        }


                    }


                }

                input = Console.ReadLine();
            }

            List<string>teamsToDisband=new List<string>();

            foreach (var team in teamsDictionary.OrderByDescending(x => x.Value.Count).ThenBy(x=>x.Value.Values))
            {
                if (team.Value.Count >=1)
                {

                    Console.WriteLine($"{team.Key}");
                    Console.WriteLine($"- {creatorDictionary[team.Key]}");
                    foreach (var member in team.Value)
                    {
                        Console.WriteLine($"-- {member.Key}");
                    }
                }

                if (team.Value.Count < 1)
                {
                    teamsToDisband.Add(team.Key);
                }
            }

                Console.WriteLine($"Teams to disband:");
            foreach (var team in teamsToDisband)
            {
                Console.WriteLine($"{team}");

            }



        }
    }
}
