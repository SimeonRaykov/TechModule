using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousCache
{
    class AnonymousCache
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();

            List<string> allowedDataSets
                = new List<string>();

            Dictionary<string, Dictionary<string, long>> dataSetsDictionary
                = new Dictionary<string, Dictionary<string, long>>();

            Dictionary<string, string> dataSetWinner
                = new Dictionary<string, string>();

            while (input != "thetinggoesskrra")
            {
                if (input.Contains(" -> ") && input.Contains(" | "))
                {
                    var tokens = input.Split("-> |".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                    var dataKey = tokens[0];
                    var dataSize = long.Parse(tokens[1]);
                    var dataSet = tokens[2];

                    if (dataSetsDictionary.ContainsKey(dataSet) == false)
                    {
                        dataSetsDictionary.Add(dataSet, new Dictionary<string, long>());
                    }

                    dataSetsDictionary[dataSet].Add(dataKey, 0);
                    dataSetsDictionary[dataSet][dataKey] += dataSize;

                }
                else
                {
                    allowedDataSets.Add(input);
                }

                input = Console.ReadLine();
            }

            var maxSum = 0L;

            foreach (var dataSet in dataSetsDictionary)
            {
                if (allowedDataSets.Contains(dataSet.Key) == false)
                {
                    continue;

                }

                var currentData = dataSet.Key;

                var currentSum = dataSet.Value.Sum(x => x.Value);

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }

            foreach (var dataSet in dataSetsDictionary)
            {

                if (dataSet.Value.Sum(x => x.Value) == maxSum)
                {
                    Console.WriteLine($"Data Set: {dataSet.Key}, Total Size: {maxSum}");
                    foreach (var dataKey in dataSet.Value)
                    {
                        Console.WriteLine($"$.{dataKey.Key}");
                    }


                }

            }




        }
    }
}
