using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;

namespace StringsTest
{
    class StringsAndTextProcessingLab
    {
        static void Main(string[] args)
        {

            String[] bannedWords = Console.ReadLine().Split(new char[]{
                ',',' '}, StringSplitOptions.RemoveEmptyEntries);
            String text = Console.ReadLine();
            foreach (var item in bannedWords)
            {
                text = text.Replace(item, new string('*', item.Length));
            }
            Console.WriteLine(text);



        }
    }
}
