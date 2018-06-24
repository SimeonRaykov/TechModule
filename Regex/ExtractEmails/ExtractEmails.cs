using System;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
             string input = Console.ReadLine();
            string regex =
                @"(^|(?<=\s))([A-Za-z0-9]+)([-_.][A-Za-z0-9]+)?@([A-Za-z0-9]+\b[-]?[A-z0-9a-z]?)+.([A-Za-z0-9])+([.]?[A-Za-z0-9]*)\b";

            MatchCollection emails= Regex.Matches(input, regex);

            

            foreach (Match email in emails)
            {

                Console.WriteLine(email.Value);

            }


        }
    }
}
