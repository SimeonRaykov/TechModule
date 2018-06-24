using System;
using System.Linq;

namespace MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());
            string result = "";

   

            for (int i = firstChar; i <= secondChar; i++)
            {
                for (int j = firstChar; j <= secondChar; j++)
                {
                    for (int k = firstChar; k <= secondChar; k++)
                    {
                        result = $"{(char)i}{(char)j}{(char)k}";

                        if (!(result.Contains(thirdChar)))
                        {

                            Console.Write($"{result} ");
                        }
                    }
                }
            }

        }
    }
}
