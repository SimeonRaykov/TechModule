using System;
using System.Collections.Generic;
using System.Linq;

namespace EnduranceRally
{
    class EnduranceRally
    {
        static void Main(string[] args)
        {


            string[] names = Console.ReadLine()
                .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            double[] paths = Console.ReadLine()
                .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            List<int> checkPoints = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            var startingFuel = 0;
            double sum = 0;


            foreach (var name in names)
            {

                startingFuel = name[0];
                sum = startingFuel;

                for (int i = 0; i < paths.Length; i++)
                {
                    if (checkPoints.Contains(i))
                    {
                        sum += paths[i];
                    }
                    else
                    {
                        sum -= paths[i];
                    }

                    if (sum <= 0)
                    {
                        Console.WriteLine($"{name} - reached {i}");
                        break;
                    }


                }

                if (sum > 0)
                {
                    Console.WriteLine($"{name} - fuel left {sum:F2}");
                }

                sum = 0;

            }
        }
    }
}
