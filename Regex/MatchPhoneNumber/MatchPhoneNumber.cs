using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"[+]{1}\b[359]{3}\b[ ]{1}\b[2]\b[ ]{1}\b[0-9]{3}\b[ ]{1}[0-9]{4}|[+]{1}\b[359]{3}\b[-]{1}\b[2]\b[-]{1}\b[0-9]{3}\b[-]{1}\b[0-9]{4}\b";
               


MatchCollection matchedNames = Regex.Matches(input,pattern);

            var matchedPhones = matchedNames.Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(String.Join(", ",matchedPhones));

        }
    }
}
