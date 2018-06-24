using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace MorseCode
{
    class MorseCode
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);

            bool isStart = true;
            var countSeq = 0;
            var sum = 0;

            List<char> finalWord = new List<char>();

            foreach (var word in input)
            {
                for (int i = 0; i < word.Length - 1; i++)
                {
                    if (word[i] == '0')
                    {
                        sum += 3;
                    }
                    else if (word[i] == '1')
                    {
                        sum += 5;
                    }

                    if (word[i] == word[i + 1])
                    {
                        if (isStart)
                        {
                            countSeq += 2;
                            isStart = false;
                        }
                        else
                        {
                            countSeq += 1;
                        }
                    }
                    else
                    {
                        countSeq = 0;
                        isStart = true;
                    }
                    sum += countSeq;
                    countSeq = 0;

                }

                if (word[word.Length - 1] == '1')
                {
                    sum += 5;
                }
                else
                {
                    sum += 3;
                }

                char X = (char)sum;
                finalWord.Add(X);
                countSeq = 0;
                isStart = true;
                sum = 0;

            }

            foreach (var @char in finalWord)
            {
                Console.Write(@char);
            }




        }
    }
}
