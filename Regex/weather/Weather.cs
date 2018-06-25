using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Weather
{
    class Weather
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();

            var pattern = @"([A-Z]{2})([\d]+.[\d]{1,2})([A-Za-z]+?(?=\|))";

            Dictionary<string, string> weatherDictionary = new Dictionary<string, string>();
            Dictionary<string, double> averageTemp = new Dictionary<string, double>();
            Dictionary<string,KeyValuePair<string,double>>finalDictionary
                =new Dictionary<string, KeyValuePair<string, double>>();

            var townCode = "";
            var temperature = 0d;
            var typeOfWeather = "";

            while (input != "end")
            {

                Regex regex = new Regex(pattern);

                var match = Regex.Match(input, pattern);

                if (regex.IsMatch(input))
                {

                    townCode = match.Groups[1].ToString();
                    temperature = double.Parse(match.Groups[2].ToString());
                    typeOfWeather = match.Groups[3].ToString();


                    if (weatherDictionary.ContainsKey(townCode) == false)
                    {
                        weatherDictionary.Add(townCode, "");

                    }

                    if (averageTemp.ContainsKey(townCode) == false)
                    {
                        averageTemp.Add(townCode, 0);
                    }

                    if (finalDictionary.ContainsKey(townCode) == false)
                    {
                        finalDictionary.Add(townCode,new KeyValuePair<string, double>());

                    }

                    weatherDictionary[townCode] = typeOfWeather;
                    averageTemp[townCode] = temperature;
                }
                

                input = Console.ReadLine();
            }


          // foreach (var town in averageTemp.OrderBy(x=>x.Value))
          // {
          //     if (town.Key != null && town.Value != 0 && weatherDictionary[town.Key] != null)
          //     {
          //
          //         Console.WriteLine($"{town.Key} => {town.Value:F2} => {weatherDictionary[town.Key]}");
          //     }
          //
          // }

            foreach (var town in finalDictionary)
            {

                Console.WriteLine($"{town.Key} {town.Value}");

            }


        }
    }
}