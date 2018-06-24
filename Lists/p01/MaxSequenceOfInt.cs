using System;
using System.Collections.Generic;
using System.Linq;

namespace p01
{
    class MaxSequenceOfInt
    {
        static void Main(string[] args)
        {
            List<int> listNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            int counter = 1;
            int counterMax = 0;
            int numberMax = 0;

            for (int i = 0; i < listNumbers.Count - 1; i++)
            {
                if (listNumbers[i] == listNumbers[i + 1])
                {
                    counter += 1;
                    if (counterMax < counter)
                    {
                        counterMax = counter;
                        numberMax = listNumbers[i];
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            //         if (counterMax < counter)
            //         {
            //             counterMax = counter;
            //             numberMax = listNumbers[i];
            //         }
            if (counterMax <= 0)
            {
                Console.Write($"{listNumbers[0]} ");
            }
            for (int i = 0; i < counterMax; i++)
            {
                Console.Write($"{numberMax} ");

            }
        }
    }
}
