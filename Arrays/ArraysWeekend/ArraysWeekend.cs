using System;

namespace ArraysWeekend
{
    class ArraysWeekend
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                string[] daysOfWeek = new string[7];

                daysOfWeek[0] = "Monday";
                daysOfWeek[1] = "Tuesday";
                daysOfWeek[2] = "Wednesday";
                daysOfWeek[3] = "Thursday";
                daysOfWeek[4] = "Friday";
                daysOfWeek[5] = "Saturday";
                daysOfWeek[6] = "Sunday";


                Console.WriteLine($"{daysOfWeek[number - 1]}");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid day!");
            }
            



        }
    }
}

