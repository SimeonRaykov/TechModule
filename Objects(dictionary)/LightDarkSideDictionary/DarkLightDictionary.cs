using System;
using System.Collections.Generic;
using System.Linq;

namespace LightDarkSideDictionary
{
    class DarkLightDictionary
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> forceDictionary
                = new Dictionary<string, Dictionary<string, int>>();

            Dictionary<string, string> checkDictionary
                = new Dictionary<string, string>();

            var user = "";
            var side = "";
            int countR = 0;

            var oldSide = "";
            var xSideX = "";
            bool lastIteration = false;

  

            while (input != "Lumpawaroo")
            {
                if (input.Contains(" | "))
                {
                    var tokens = input.Split(" | ", StringSplitOptions.RemoveEmptyEntries);

                    side = tokens[0];
                    user = tokens[1];
                    oldSide = side;

                    if (forceDictionary.ContainsKey(side) == false)
                    {
                        forceDictionary.Add(side, new Dictionary<string, int>());
                    }

                    if (forceDictionary[side].ContainsKey(user)==false)
                    {

                        forceDictionary[side].Add(user, 0);
                        forceDictionary[side][user] += 1;

                    }

                    xSideX = side;
                    lastIteration = true;
                }
                else if (input.Contains(" -> "))
                {

                    var tokens = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                    user = tokens[0];
                    side = tokens[1];
               

                    if (forceDictionary.ContainsKey(side) == false)
                    {
                       
                        forceDictionary.Add(side, new Dictionary<string, int>());
                    }

                    if (forceDictionary.ContainsKey(oldSide) == false)
                    {
                        forceDictionary.Add(oldSide, new Dictionary<string, int>());
                    }

                    if (forceDictionary.ContainsKey(xSideX) == false)
                    {
                        forceDictionary.Add(xSideX,new Dictionary<string, int>());
                    }


                    if (forceDictionary[oldSide].ContainsKey(user))
                    {
                        forceDictionary[oldSide].Remove(user);
                        
                    }

                    if (forceDictionary[xSideX].ContainsKey(user))
                    {
                        forceDictionary[xSideX].Remove(user);
                        
                    }

                    if (forceDictionary[side].ContainsKey(user) == false)
                    {
                        forceDictionary[side].Add(user, 0);


                        Console.WriteLine($"{user} joins the {side} side!");

                    }

                    if (countR == 0)
                    {
                    oldSide = side;

                    }

                    lastIteration = false;

                }

                countR = 0;
                input = Console.ReadLine();
            }


            foreach (var forceSide in forceDictionary.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                var count = forceSide.Value.Count;

                if (count != 0)
                {
                    Console.WriteLine($"Side: {forceSide.Key}, Members: {count}");

                    foreach (var forceUser in forceSide.Value.OrderBy(y => y.Key))
                    {
                        Console.WriteLine($"! {forceUser.Key}");
                    }
                }
            }
        }
    }
}