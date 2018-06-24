using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchHexadecimalNumbers
{
    class MatchHexadecimalNumbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern=@"\b[0x]*[0-9]+[A-F]+\b|\b[0x]*[A-F]+\b|\b[0x]*[0-9]+\b";
            //  string pattern = @"[0x?]*[0-9A-F]+\b";
          //  string pattern = @"\b[0x]*[0-9A-F]+\b";

            MatchCollection matchHexa = Regex.Matches(input, pattern);

            var matchedHexa = matchHexa.Cast<Match>()
                .Select(a => a.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ", matchedHexa));
          




        }
    }
}
