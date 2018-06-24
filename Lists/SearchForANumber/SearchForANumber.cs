using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchForANumber
{
    class SearchForANumber
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine().Split(" ")
                .Select(int.Parse).ToList();
            int[] arrayNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            if (numbersList.Take(arrayNumbers[0]).Skip(arrayNumbers[1]).Contains(arrayNumbers[2]))
            {
                Console.WriteLine("YES!");
            }
            else 
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
