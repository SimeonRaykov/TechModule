using System;
using System.Linq;

namespace InventoryMatcher
{
    class InventoryMatcher
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            long[] numbers = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            decimal[] prices = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (command!="done")
            {
                if (command != "done")
                {
                    var index = Array.IndexOf(products,command);

                    Console.WriteLine($"{command} costs: {prices[index]}; Available quantity: {numbers[index]}");



                }



                command = Console.ReadLine();
            }





        }
    }
}
