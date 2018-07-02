using System;

namespace ConsoleApp1
{
    class SoftuniReception
    {
        static void Main(string[] args)
        {

            decimal firstColleague = decimal.Parse(Console.ReadLine());
            decimal secondColleague = decimal.Parse(Console.ReadLine());
            decimal thirdColleague = decimal.Parse(Console.ReadLine());
            decimal studentCount = decimal.Parse(Console.ReadLine());

            decimal sumPerHour = firstColleague
                             + secondColleague
                             + thirdColleague;

            var i = 0;

            while (studentCount>0)
            {
                if (i % 4 == 0)
                {
                    i++;
                    continue;
                }

                studentCount -= sumPerHour;

                if (studentCount <= 0)
                {
                    break;
                }
               

                i++;
            }

            Console.WriteLine($"Time needed: {i}h.");


        }
    }
}
