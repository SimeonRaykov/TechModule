using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniKaraoke
{
    class SoftUniKaraoke
    {
        static void Main(string[] args)
        {

            var counterX = 0;
            string[] participantsAward = Console.ReadLine()
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim()).ToArray();

            string[] participantSongs = Console.ReadLine()
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            List<string> participantsContained = new List<string>();

            List<string> availableSongs = new List<string>();

            for (int index = 0; index < participantSongs.Length; index++)
            {
                availableSongs.Add(participantSongs[index]);

            }

            for (int i = 0; i < participantsAward.Length; i++)
            {
                participantsContained.Add(participantsAward[i]);
            }



            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> karaokenDictionary
                = new Dictionary<string, Dictionary<string, int>>();


            while (input != "dawn")
            {
              //  var tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);


                string[] tokens = input
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim()).ToArray();



                var name = tokens[0];
                if (participantsContained.Contains(name))
                {
                    var song = tokens[1];
                    var award = tokens[2];

                    if (availableSongs.Contains(song))
                    {

                        if (karaokenDictionary.ContainsKey(name) == false)
                        {
                            karaokenDictionary.Add(name, new Dictionary<string, int>());
                        }

                        if (karaokenDictionary[name].ContainsKey(award))
                        {
                            input = Console.ReadLine();
                            continue;
                        }

                        karaokenDictionary[name].Add(award, 0);
                        karaokenDictionary[name][award] += 1;
                        counterX += 1;
                    }
                }



                input = Console.ReadLine();
            }

            if (counterX == 0)
            {
                Console.WriteLine($"No awards");
            }

            foreach (var karaokeParticipant in karaokenDictionary.OrderByDescending(x => x.Value.Count).ThenBy(y => y.Key))
            {
                var counter = karaokeParticipant.Value.Count;

                Console.WriteLine($"{karaokeParticipant.Key}: {counter} awards");

                foreach (var karaokeAward in karaokeParticipant.Value.OrderBy(x => x.Key))
                {

                    Console.WriteLine($"--{karaokeAward.Key}");
                }

            }




        }
    }
}
