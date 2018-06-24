using System;
using System.Numerics;

namespace FromBase10ToBaseN
{
    class FromBase10ToBaseN
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            int baseN = int.Parse(input[0]);
            BigInteger number=new BigInteger();
            number = BigInteger.Parse(input[1]);

           // BigInteger number = BigInteger.Parse(input[1]);
            BigInteger reminder = 0;
            string result = "";

            while (number>0)
            {
                reminder = number % baseN;
                number /= baseN;
                result = reminder.ToString()+result;


            }

            Console.WriteLine(result);
        }
    }
}
