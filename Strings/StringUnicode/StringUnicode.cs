using System;

namespace StringUnicode
{
    class StringUnicode
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            foreach (var @char in input)
            {
                Console.Write($"\\u{(int)(@char):x4}");
            }



        }
    }
}
