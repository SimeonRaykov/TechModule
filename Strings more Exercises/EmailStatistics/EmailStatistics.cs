using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace EmailStatistics
{
    class EmailStatistics
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

          Dictionary<string,Dictionary<string,int>>
              emailsDictionary
                  =new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string pattern = @"\b[A-Za-z]{5,}@[a-z]{3,}(\.com|\.bg|\.org)\b";

                Regex regex=new Regex(pattern);

                if (regex.IsMatch(input))
                {
                    var tokens = input.Split("@");

                    var user = tokens[0];
                    var email = tokens[1];

                    if (emailsDictionary.ContainsKey(email) == false)
                    {
                        emailsDictionary.Add(email,new Dictionary<string, int>());
                    }

                    if (emailsDictionary[email].ContainsKey(user) == false)
                    {
                        emailsDictionary[email].Add(user,0);
                    }

                    emailsDictionary[email][user] += 1;


                }



            }

            foreach (var email in emailsDictionary.OrderByDescending(x=>x.Value.Values.Count))
            {

                Console.WriteLine($"{email.Key}:");
                foreach (var user in email.Value)
                {
                Console.WriteLine($"### {user.Key}");
                    
                }


            }





        }
    }
}
