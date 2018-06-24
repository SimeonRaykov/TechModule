using System;
using System.Collections.Generic;
using System.Linq;

namespace PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split("|").ToArray();

            Dictionary<string, Dictionary<string, long>> countriesAndCities
                = new Dictionary<string, Dictionary<string, long>>();

            Dictionary<string, long> totalPopulation = new Dictionary<string, long>();

            while (input[0] != "report")
            {
                string country = input[1];
                string city = input[0];
                long population = long.Parse(input[2]);

                if (totalPopulation.ContainsKey(country) == false)
                {
                    totalPopulation.Add(country, 0);
                    countriesAndCities.Add(country, new Dictionary<string, long>());
                }

                totalPopulation[country] += population;

                if (countriesAndCities.ContainsKey(country) == false)
                {
                    countriesAndCities[country].Add(city, population);



                }

                input = Console.ReadLine().Split("|").ToArray();
            }

            foreach (var country in totalPopulation.OrderByDescending(c => c.Value))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value})");

            

            var cities = countriesAndCities[country.Key]
                    .OrderByDescending(c => c.Value)
                    .ToDictionary(x => x.Key, x => x.Value);


                foreach (var city in cities)
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }

            }




        }
    }
}
