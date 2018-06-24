using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
namespace reverseString
{
    class reverseString
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            Console.WriteLine(TopMethodToReverse(first));
        }

        private static string TopMethodToReverse(string first)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = first.Length - 1; i >= 0; i--)
            {
                sb.Append(first[i]);
            }
            return sb.ToString();
        }
    }
}
