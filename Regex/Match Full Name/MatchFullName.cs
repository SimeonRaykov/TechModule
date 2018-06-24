using System;
using System.Text.RegularExpressions;

namespace Match_Full_Name
{
    class MatchFullName
    {
        static void Main(string[] args)
        {

            string regex = @"\b[A-Z]{1}[a-z]+[ ]{1}[A-Z]{1}[a-z]+\b";
            string namesX = Console.ReadLine();

            MatchCollection matchedNames = Regex.Matches(namesX, regex);

            foreach (Match names in matchedNames)
            {

                Console.Write(names.Value+" ");

            }

            Console.WriteLine();

        }
    }
}
