using System;
using System.Text.RegularExpressions;

namespace CensorShip
{
    class CensorShip
    {
        static void Main(string[] args)
        {

            string bannedWord = Console.ReadLine();

            string mex = new string('*', bannedWord.Length); 

            string input = Console.ReadLine();
            string pattern = $@"{bannedWord}";
            string result = Regex.Replace(input, pattern, mex);
            Console.WriteLine(result);


        }
    }
}
