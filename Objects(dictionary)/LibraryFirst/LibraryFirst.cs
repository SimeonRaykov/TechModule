using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryFirst
{
    class LibraryFirst
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, double> authorPrice
                = new Dictionary<string, double>();


            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var author = tokens[1];
                var price = double.Parse(tokens[5]);

                if (authorPrice.ContainsKey(author) == false)
                {
                    authorPrice.Add(author,0);
                }

                authorPrice[author] += price;

            }

            foreach (var author in authorPrice.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {

                var currentSum = author.Value;

                Console.WriteLine($"{author.Key} -> {author.Value:F2}");

            }


        }
    }
}
