using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace MemoryView
{
    class MemoryView
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var text = "";
     


            while (input != "Visual Studio crash")
            {
                text += input+" ";


                input = Console.ReadLine();
            }

            //            text = text.Trim();
            text = Regex.Replace(text, @"\s+", " ");

            string pattern = @"32656 19759 32763 0 ([\d]+) 0";

            var countToMatch = 0;


            MatchCollection firstTime = Regex.Matches(text, pattern);

            foreach (Match match in firstTime)
            {
                countToMatch = int.Parse(match.Groups[1].ToString());

                string patternDos = @"32656 19759 32763 0 ([\d]+) 0(( [\d]+)" + "{" + $"{countToMatch}" + "})";

                Match matchDos = Regex.Match(text, patternDos);

                var groupedMatch = matchDos.Groups[2].ToString();
                groupedMatch = groupedMatch.Trim();
                var groupedMatchArray = groupedMatch.Split(" ", StringSplitOptions.RemoveEmptyEntries);


                int intCharacterOfName = 0;
                var personalName = "";

                for (int i = 0; i < groupedMatchArray.Length; i++)
                {
                    intCharacterOfName = int.Parse(groupedMatchArray[i]);
                    var currentCharacter = (char)intCharacterOfName;

                    personalName += currentCharacter;

                }

                Console.WriteLine(personalName);

                if (matchDos.ToString().Length != 0)
                {
               text = text.Replace(matchDos.ToString(), "");

                }

                
            }
        }
    }
}