using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;

namespace ValidUsernames
{
    class ValidUsernames
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[]{' ',')','(','\\','/'},StringSplitOptions.RemoveEmptyEntries).ToArray();

            string pattern = @"^[a-zA-Z][a-zA-Z0-9_]{2,24}$";

            Regex regex=new Regex(pattern);


            var collection = new List<string>();

            foreach (var VARIABLE in input)
            {

                if (regex.IsMatch(VARIABLE))
                {
                    collection.Add(VARIABLE);

                }

                
            }

            int maxSum = 0;
            int currentSum = 0;
            string first = "";
            string second = "";

            for (int i = 0; i < collection.Count - 1; i++)
            {
                currentSum = collection[i].Length + collection[i + 1].Length;

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    first = collection[i];
                    second = collection[i + 1];
                }



            }

            Console.WriteLine(first);
            Console.WriteLine(second);



        }
    }
}
