using System;

namespace CenturiesToNanoseconds
{
    class CenturiesToNanoSeconds
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            short years = (short)(centuries * 100);
            int days = (int)(365.2422 * years);
            int hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = "
                    +$"{seconds} seconds = {seconds}000 milliseconds = {seconds}000000"
            +($" microseconds = {seconds}000000000 nanoseconds"));



        }
    }
}
