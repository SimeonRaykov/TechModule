using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace aMinerTask
{
    class MinerTask
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> miningResources
                            = new Dictionary<string, int>();

            string command = Console.ReadLine();
               

            while (command != "stop")
            {
                for (int i = 0; i <1; i++)
                {
                    string typeOfResource = command;
                    int quantityResource=int.Parse(Console.ReadLine());


                    if (miningResources.ContainsKey(typeOfResource))
                    {
                        miningResources[typeOfResource] += quantityResource;
                    }
                    else
                    {
                      miningResources.Add(typeOfResource,quantityResource);
                    }


                }
            command = Console.ReadLine();
            }


            foreach (var resource in miningResources)
            {

                Console.WriteLine($"{resource.Key} -> {resource.Value}");


            }





        }
    }
}
