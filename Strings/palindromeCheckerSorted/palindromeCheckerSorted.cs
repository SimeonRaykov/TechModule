using System;
using System.Collections.Generic;
using System.Linq;

namespace palindromeCheckerSorted
{
    class palindromeCheckerSorted
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(" ,.?!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            List<string> words = new List<string>();
            bool isPalindrome;

            for (int i = 0; i < input.Length; i++)
            {
                if (getStatus(input[i]))
                {
                    words.Add(input[i]);
                }

            }

            words.Sort();
            words = words.Distinct().ToList();



            Console.WriteLine(string.Join(", ", words));


        }

        public static bool getStatus(string myString)
        {
            string first = myString.Substring(0, myString.Length / 2);
            char[] arr = myString.ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);
            return first.Equals(second);
        }
    }
}
