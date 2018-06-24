using System;
using System.Linq;

namespace KaminoFactory
{
    class KaminoFactory
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            var subSeqCount = 0;
            var subSeqMaxCount = 0;
            var currentStartIndex = -1;
            var bestStartIndex = 0;
            int[] bestArrayArrayX = new[] { n };

            var currentEndIndex = 0;

            var bestSum = 0;
            var bestIndex = 0;
            var currentBest = 0;

            bool isBest = false;

            var topIndex = 2;
            var bestArray = new int[n];

            bool isFirst = false;

            var input = Console.ReadLine();

            while (input != "Clone them!")
            {

                var currentArray = input.Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                for (int i = 0; i < currentArray.Length; i++)
                {
                    if (currentArray[i] == 1)
                    {
                            subSeqCount += 1;
                            if (subSeqCount > currentBest)
                            {
                            currentEndIndex = i;
                                currentBest = subSeqCount;
                            }
                    }
                    else
                    {
                        subSeqCount = 0;
                    }
                }

                currentStartIndex = currentEndIndex - currentBest;

                if (subSeqMaxCount < currentBest)
                {
                    isBest = true;

                }
                else if (currentBest == subSeqMaxCount)
                {
                    if (currentStartIndex > bestStartIndex)
                    {
                        isBest = true;
                    }
                }
                else if (bestStartIndex == currentStartIndex)
                {
                    if (currentArray.Sum() > bestArrayArrayX.Sum())
                    {
                        isBest = true;
                    }

                }

                if (isBest)
                {
                    subSeqMaxCount = currentBest;
                    bestArray = currentArray;
                    bestSum = currentArray.Sum();
                    bestIndex = topIndex;
                    bestStartIndex = currentStartIndex;


                }
                topIndex += 1;
                input = Console.ReadLine();

            }

            Console.WriteLine($"Best DNA sample {bestIndex - 1} with sum: {bestSum}.");
            Console.WriteLine($"{string.Join(" ", bestArray)}");

        }
    }


}


