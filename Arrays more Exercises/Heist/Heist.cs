using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int jewelValue = input[0];
            int goldValue = input[1];
            int expenses = 0;
           int jewelCount = 0;
           int goldCount = 0;
            int totalExpenses = 0;
            int totalEarnings = 0;


            string commands = Console.ReadLine();

            while (commands != "Jail Time")
            {
                if (commands != "Jail Time")
                {

                    var commandX = commands.Split(" ");

                    var currentString = commandX[0];
                    expenses = int.Parse(commandX[1]);



                    jewelCount =  currentString.Split('%').Length - 1;

                    goldCount = currentString.Split('$').Length - 1;

                    //  jewelCount = commandX[0].Count(x => x == '%');
                    //  goldCount = commandX[0].Count(x => x == '$');


                    totalExpenses += expenses;
                    totalEarnings += (jewelCount * jewelValue) + (goldCount * goldValue);

                }

                commands = Console.ReadLine();
            }



            if (totalEarnings >= totalExpenses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalEarnings - totalExpenses}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {totalExpenses - totalEarnings}.");
            }

        }


    }

}



