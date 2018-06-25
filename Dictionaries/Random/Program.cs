using System;
using System.Linq;
using System.Security.Cryptography;

namespace Randoms
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split();

            Random rnd = new Random();
            string[] MyRandomArray = input.OrderBy(x => rnd.Next()).ToArray();

            foreach (var s in MyRandomArray)
            {

                Console.WriteLine(s);

            }


        }
    }
}
