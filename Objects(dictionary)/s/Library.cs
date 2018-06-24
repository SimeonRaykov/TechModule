using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;

namespace s
{
    class Library
    {
        static void Main(string[] args)
        {
            List<string>allowedMentors=new List<string>();

            Dictionary<string, Dictionary<DateTime, string>> mentorsDictionary
                = new Dictionary<string, Dictionary<DateTime, string>>();

            Dictionary<string, string> mentorsComments
                = new Dictionary<string, string>();


            DateTime currentDate = DateTime.Now;
            string user = "";

            string input = Console.ReadLine();

            while (input != "end of dates")
            {
                var tokens = input.Split(" ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                user = tokens[0];

                if (mentorsDictionary.ContainsKey(user) == false)
                {
                    mentorsDictionary.Add(user, new Dictionary<DateTime, string>());
                }

                if (mentorsComments.ContainsKey(user) == false)
                {
                    mentorsComments.Add(user, "");
                }
                for (int i = 1; i <= tokens.Length - 1; i++)
                {
                    currentDate =
                       DateTime.ParseExact($"{tokens[i]}", "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    string sDate = currentDate.ToShortDateString();
                    currentDate = DateTime.Parse(sDate);

                    mentorsDictionary[user].Add(currentDate, "");

                }

                if (allowedMentors.Contains(user) == false)
                {
                    allowedMentors.Add(user);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "end of comments")
            {
                var tokens = input.Split("-".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                var userX = tokens[0];

                if (allowedMentors.Contains(userX) == false)
                {
                    input = Console.ReadLine();
                    continue;
                }
                var comment = tokens[1];

                if (mentorsComments.ContainsValue(comment) == false)
                {
                    mentorsComments[userX] += comment+Environment.NewLine;
                }
                else
                {
                    mentorsComments[userX] += comment+Environment.NewLine;

                }


                input = Console.ReadLine();
            }


            foreach (var mentor in mentorsDictionary.OrderBy(x => x.Key))
            {
                if (mentor.Value != null)
                {



                    Console.WriteLine($"{mentor.Key}");
                    Console.WriteLine($"Comments:");
                    if (mentorsComments[mentor.Key].Length != 0)
                    {

                        Console.Write($"- {mentorsComments[mentor.Key]}");
                    }

                    Console.WriteLine($"Dates attended:");
                    foreach (var mentorDate in mentor.Value.OrderBy(x => x.Key))
                    {
                        var currentDateX = mentorDate.Key;

                        Console.WriteLine($"-- {currentDateX.ToString("dd/MM/yyyy")}");

                    }

                }
            }



        }
    }
}
