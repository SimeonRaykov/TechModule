using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SRBSKO
{
    class SRBSKO
    {
        static void Main(string[] args)
        {
            var pattern = @"(^)(?<first>(([A-Za-z]+ ){1,3}))@(?<second>(([A-Za-z]+ )){1,3})([\d]+)( [\d]+)$";

            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, long>> townDictionary
                = new Dictionary<string, Dictionary<string, long>>();

            Regex regex = new Regex(pattern);
            while (input != "End")
            {
                var match = Regex.Match(input, pattern);

                if (regex.IsMatch(input))
                {

                    var singer = match.Groups["first"].ToString().Trim();
                    var townName = match.Groups["second"].ToString().Trim();


                    var ticketPrice = long.Parse(match.Groups[6].ToString());
                    var ticketCountString = match.Groups[7].ToString();
                    var ticketCount = long.Parse(ticketCountString);


                    if (townDictionary.ContainsKey(townName) == false)
                    {
                        townDictionary.Add(townName, new Dictionary<string, long>());
                    }

                    if (townDictionary[townName].ContainsKey(singer) == false)
                    {
                        townDictionary[townName].Add(singer, 0);
                    }

                    townDictionary[townName][singer] += ticketCount * ticketPrice;

                }


                input = Console.ReadLine();

            }


            foreach (var town in townDictionary)
            {

                Console.WriteLine($"{town.Key}");
                


                foreach (var singer in town.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");


                }




            }







        }
    }
}
