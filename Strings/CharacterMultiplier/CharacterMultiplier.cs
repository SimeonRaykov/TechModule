using System;

namespace CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string first = input[0];
            string second = input[1];
            int sum = 0;

            for (int i = 0; i < Math.Min(first.Length,second.Length); i++)
            {
                sum += first[i] * second[i];
            }

            for (int i = Math.Min(first.Length,second.Length); i < Math.Max(first.Length,second.Length); i++)
            {
                //Variant 1

                if (first.Length > second.Length)
                {
                    sum += first[i];
                }
                else if(second.Length>first.Length)
                {
                    sum += second[i];
                }
                //Variant 2

         /*       try
                {
                    sum += first[i];
                }
                catch
                {
                    sum += second[i];
                } */
            }

            Console.WriteLine(sum);



        }
    }
}
