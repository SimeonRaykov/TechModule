using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Snowwhite
{
    class SnowWhite
    {
        static void Main(string[] args)
        {
         Dictionary<string,Dictionary<string,long>>dwardsDictionary
             =new Dictionary<string, Dictionary<string, long>>();


             


            var input = Console.ReadLine();


            while (input!="Once upon a time")
            {
                var tokens = input.Split(" <:> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                var name = tokens[0];
                var color = tokens[1];
                var attack = long.Parse(tokens[2]);

                if (dwardsDictionary.ContainsKey(color) == false)
                {
                    dwardsDictionary.Add(color,new Dictionary<string, long>());
                }

                if (dwardsDictionary[color].ContainsKey(name) == false)
                {
                    dwardsDictionary[color].Add(name,attack);
                }

                if (dwardsDictionary[color].ContainsKey(name))
                {

                    if (dwardsDictionary[color][name] < attack)
                    {

                        dwardsDictionary[color][name] = attack;

                    }


                }






                input = Console.ReadLine();
            }

            var isFirst = true;

            foreach (var color in dwardsDictionary.OrderByDescending(x=>x.Value.Values.Sum()).ThenBy(x=>x.Value.Keys.Count()))
            {

                Console.Write($"({color.Key}) ");

                foreach (var dwarf in color.Value.OrderByDescending(x=>x.Value).OrderByDescending(x=>x.Value))
                {
                    if (isFirst)
                    {
                    Console.WriteLine($"{dwarf.Key} <-> {dwarf.Value}");

                    }
                    else
                    {
                        Console.WriteLine($"({color.Key}) {dwarf.Key} <-> {dwarf.Value}");
                    }

                    isFirst = false;
                }

                isFirst = true;
            }

       
        

        }
    }
}
