using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace regexReplace5
{
    class RegexReplace
    {
        static void Main(string[] args)
        {

            var keys = Console.ReadLine();
            var textInput = Console.ReadLine();

            string pattern = @"(.+)([|\\\<]{1})(.+)([|\\\<]{1})(.+)";

            Regex regex=new Regex(pattern);


            var match = Regex.Match(keys, pattern);

            var keyStart = match.Groups[1];
            var keyEnd = match.Groups[5];

            string wordPattern = $@"(?<={keyStart})(.+)(?={keyEnd})";

            var finalMatch = Regex.Match(textInput, wordPattern);

            var finalString = "";

            var wordzPattern = $@"{keyStart}(?!{keyEnd})(.*?){keyEnd}";

            MatchCollection matchedCollection = Regex.Matches(textInput, wordzPattern);

            foreach (Match coll in matchedCollection)
            {

                finalString += coll.Groups[1].Value;


            }

            if (finalString != "")
            {
            Console.WriteLine(finalString);

            }
            else
            {
                Console.WriteLine("Empty result");
            }
        }
    }
}
