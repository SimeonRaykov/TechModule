using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DragonArmy
{
    class DragonArmy
    {
        static void Main(string[] args)
        {
            var dragonsDictionary
                  = new Dictionary<string, Dictionary<string, Dictionary<decimal, Dictionary<decimal, decimal>>>>();

            var damage = 0M;
            var health = 0M;
            var armor = 0M;

            int n = int.Parse(Console.ReadLine());
            string[] input = { };

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                var type = input[0];
                var name = input[1];

                if (input[2] == "null")
                {
                    damage = 45;
                }
                else
                {
                    damage = decimal.Parse(input[2]);
                }

                if (input[3] == "null")
                {
                    health = 250;
                }
                else
                {
                    health = decimal.Parse(input[3]);
                }

                if (input[4] == "null")
                {
                    armor = 10;
                }
                else
                {
                    armor = decimal.Parse(input[4]);

                }




                if (dragonsDictionary.ContainsKey(type) == false)
                {
                    dragonsDictionary.Add(type,
                        new Dictionary<string, Dictionary<decimal, Dictionary<decimal, decimal>>>());


                }

                if (dragonsDictionary[type].ContainsKey(name) == false)
                {
                    dragonsDictionary[type].Add(name, new Dictionary<decimal, Dictionary<decimal, decimal>>());


                }

                if (dragonsDictionary[type][name].ContainsKey(damage) == false)
                {
                    dragonsDictionary[type][name].Add(damage, new Dictionary<decimal, decimal>());
                }

                else if (dragonsDictionary[type][name].ContainsKey(damage))
                {
                    dragonsDictionary[type][name].Remove(damage);

                    dragonsDictionary[type][name].Add(damage, new Dictionary<decimal, decimal>());


                }

                if (dragonsDictionary[type][name][damage].ContainsKey(health) == false)
                {
                    dragonsDictionary[type][name][damage].Add(health, 0);
                }

                else if (dragonsDictionary[type][name][damage].ContainsKey(health))

                {
                    dragonsDictionary[type][name][damage].Remove(health);

                    dragonsDictionary[type][name][damage].Add(health, armor);
                }

                //Damage health armor


                dragonsDictionary[type][name][damage][health] = armor;

             


        }


            StringBuilder sb = new StringBuilder();


            foreach (var dragon in dragonsDictionary.OrderBy(x => x.Key))
            {
                var typeOfDragon = dragon.Key;

                sb.Append($"{typeOfDragon}::");

                foreach (var dragonName in dragon.Value)
                {
                    var nameOfDragon = dragonName.Key;

                    sb.Append($"{nameOfDragon}");

                    foreach (var dragonDamage in dragonName.Value)
                    {
                        Console.Write($"{dragonDamage.Key}");
                        foreach (var dragonHealth in dragonDamage.Value)
                        {
                            var healthOfDragon = dragonHealth.Key;
                            var armorOfDragon = dragonHealth.Value;

                            sb.Append($"{healthOfDragon} {armorOfDragon}");


                        }
                    }

                }

                Console.WriteLine(sb.ToString());
            }



        }
    }
}
