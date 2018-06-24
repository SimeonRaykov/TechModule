using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
          

  int n = int.Parse(Console.ReadLine());

            for (char i = 'a'; i <=(char)('a'+n-1); i++)
            {
                for (char j = 'a'; j <=(char)('a' + n-1); j++)
                {
                    for (char k = 'a'; k <=(char)('a' + n-1); k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }


        }
    }
}
