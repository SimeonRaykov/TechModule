using System;
using System.ComponentModel.Design;
using System.Linq;

namespace UpgradedMatcher
{
    class UpgradedMatcher
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            long[] quantity = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            decimal[] prices = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToArray();

            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var index = 0;
            var indexHelper = 0;
            while (command[0] != "done")
            {
                try
                {

                    index = Array.IndexOf(products, command[0]);
                    indexHelper = Array.IndexOf(quantity, command[0]);
                }

                catch
                {
                    indexHelper = 0;
                }
                finally
                {
                    if (indexHelper == 0)
                    {
                        Console.WriteLine($"We do not have enough {command[0]}");

                    }

                    try
                    {


                        if (quantity[index] >= long.Parse(command[1]))
                        {
                            var currentCost = long.Parse(command[1]) * prices[index];

                            Console.WriteLine($"{command[0]} x {command[1]} costs {currentCost:F2}");
                            quantity[index] -= long.Parse(command[1]);
                        }
                        else
                        {
                            Console.WriteLine($"We do not have enough {command[0]}");
                        }
                    }
                    catch
                    {

                        Console.WriteLine($"We do not have enough {command[0]}");


                    }
                }
                command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }
        }
    }
}
    






