using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchNumbers
{
    class MatchNumbers
    {
        static void Main(string[] args)
        {
            string regex = @"(^|(?<=\s))(-)?\d+\.?\d*($|(?=\s))";
            string input = Console.ReadLine();

            MatchCollection numbers = Regex.Matches(input, regex);

            
    
            foreach (Match number in numbers)
            { 
                Console.Write(number.Value+" ");
            }


        }
    }
}
