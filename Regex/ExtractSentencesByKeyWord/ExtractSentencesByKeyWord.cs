using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExtractSentencesByKeyWord
{
    class ExtractSentencesByKeyWord
    {
        static void Main(string[] args)
        {

            string word = Console.ReadLine();
            string input = Console.ReadLine();
            string[] sentences = input.Split(new char[] {'!', '.', '?'}, StringSplitOptions.RemoveEmptyEntries).ToArray();



            string pattern = $@"\b{word}\b";


            foreach (var sentence in sentences)
            {

                if (Regex.IsMatch(sentence,pattern))
                {
                    Console.WriteLine(sentence.Trim());
                }
                
            }



        }
    }
}
