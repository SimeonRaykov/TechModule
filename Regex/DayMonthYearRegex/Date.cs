using System;
using System.Text.RegularExpressions;

namespace DayMonthYearRegex
{
    class Program
    {
        static void Main(string[] args)
        {

            var regex = @"\b(?<day>[\d]{2})(?<SecondGroup>[\/.-]{1})(?<month>[A-Z]{1}[a-z]{2})\2(?<year>[\d]{4})";

            var datesString = Console.ReadLine();

            var dates = Regex.Matches(datesString, regex);

            foreach (Match date in dates)
            {

                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }

        }
    }
}
