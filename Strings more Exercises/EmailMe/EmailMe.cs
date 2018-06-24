using System;

namespace EmailMe
{
    class EmailMe
    {
        static void Main(string[] args)
        {

            string []input = Console.ReadLine().Split("@");

            var before = input[0];
            var after = input[1];

            var sumBefore = 0;
            var sumAfter = 0;

            foreach (var @char in before)
            {

                sumBefore += @char;

            }

            foreach (var @char in after)
            {
                sumAfter += @char;
            }

            var isWorth = sumBefore-sumAfter;

            if (isWorth >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }



        }
    }
}
