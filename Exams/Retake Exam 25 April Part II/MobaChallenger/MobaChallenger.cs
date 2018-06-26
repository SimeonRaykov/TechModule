using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class MobaChallenge
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine()
                var playerOne = "";
                var playerTwo = "";
                var playerRole = "";
                var playerName = "";
                var playerSkill = 0L;
                List<string> lostPlayers = new List<string>();
                Dictionary<string, Dictionary<string, long>> playerDictionary
                                = new Dictionary<string, Dictionary<string, long>>();

                while (input != "Season end")
                {
                    if (input.Contains(" vs "))
                    {
                        var tokens = input.Split(" vs ");
                        playerOne = tokens[0];
                        playerTwo = tokens[1];

                        if (playerDictionary.ContainsKey(playerOne) &&
                            playerDictionary.ContainsKey(playerTwo))
                        {
                            foreach (var role in playerDictionary[playerOne])
                            {
                                if (playerDictionary[playerTwo].ContainsKey(role.Key))
                                {
                                    long powerOne = playerDictionary[playerOne][role.Key];
                                    long powerTwo = playerDictionary[playerTwo][role.Key];

                                    if (powerTwo > powerOne)
                                    {
                                        lostPlayers.Add(playerOne);
                                    }
                                    else if (powerOne > powerTwo)
                                    {
                                        lostPlayers.Add(playerTwo);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        var tokens = input.Split(" -> ");
                        playerName = tokens[0];
                        playerRole = tokens[1];
                        playerSkill = long.Parse(tokens[2]);

                        if (playerDictionary.ContainsKey(playerName) == false)
                        {
                            playerDictionary.Add(playerName, new Dictionary<string, long>());
                        }

                        if (playerDictionary[playerName].ContainsKey(playerRole) == false)
                        {
                            playerDictionary[playerName].Add(playerRole, 0);

                        }

                        if (playerDictionary[playerName][playerRole] < playerSkill)
                        {
                            playerDictionary[playerName][playerRole] = playerSkill;
                        }
                    }
                    input = Console.ReadLine();
                }
                foreach (var player in playerDictionary.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
                {
                    if (lostPlayers.Contains(player.Key) == false)
                    {
                        Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");

                        foreach (var Role in player.Value.OrderByDescending(p => p.Value).ThenBy(p => p.Key))
                        {
                            Console.WriteLine($"- {Role.Key} <::> {Role.Value}");


                        }
                    }
                }
            }
            catch (Exception e)
            {

            }
        }
    }
}