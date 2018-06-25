using System;
using System.Linq;

namespace TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {


            string[] bannedWords = Console.ReadLine()
                .Split(" ,".ToCharArray()
                    , StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string input = Console.ReadLine();



            foreach (var bannedWord in bannedWords)
            {

                input = input.Replace(bannedWord, new string('*', bannedWord.Length));



            }

            Console.WriteLine(input);
        






        }
    }
}
