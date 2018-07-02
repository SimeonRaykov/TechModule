using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniExamResults
{
    class SoftUniExamResults
    {
        static void Main(string[] args)
        {
       
            List<string>bannedStudents=new List<string>();

            Dictionary<string, int> participants = new Dictionary<string, int>();
            Dictionary<string,int>submissionsCount=new Dictionary<string, int>();

          var  input = Console.ReadLine();
            while (input!="exam finished")
            {
                if (input.Contains("-banned"))
                {
                    var tokens = input.Split("-", StringSplitOptions.RemoveEmptyEntries);

                    var bannedName = tokens[0];
                    bannedStudents.Add(bannedName);
                }
                else
                {
                    var tokens = input.Split("-", StringSplitOptions.RemoveEmptyEntries);

                    var name = tokens[0];
                    var language = tokens[1];
                    var points = int.Parse(tokens[2]);

                    if (participants.ContainsKey(name) == false)
                    {
                        participants.Add(name,points);
                    }
                    else if (participants.ContainsKey(name))
                    {

                        if (participants[name] < points)
                        {
                            participants[name] = points;
                        }

                    }

                    if (submissionsCount.ContainsKey(language) == false)
                    {
                        submissionsCount.Add(language,0);
                    }

                    submissionsCount[language] += 1;


                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Results:");

            foreach (var participant in participants.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                if (bannedStudents.Contains(participant.Key) == false)
                {
                    Console.WriteLine($"{participant.Key} | {participant.Value}");


                }


            }
            Console.WriteLine("Submissions:");

            foreach (var submission in submissionsCount.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {

                Console.WriteLine($"{submission.Key} - {submission.Value}");


            }




        }
    }
}
