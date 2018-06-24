using System;
using System.Linq;
using System.Numerics;

namespace FromBaseNToBase10
{
    class FromBaseNToBase10
    {
        static void Main(string[] args)
        {
            String[] input = Console.ReadLine().Split(" ");
            int baseN = int.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);
            String result = "";
            BigInteger reminder = 0;
            result = FromBase(number, baseN).ToString();
            Console.WriteLine(result);
        }

        public static BigInteger FromBase(BigInteger value, int @base)
        {
            string number = value.ToString();
            BigInteger n = 1;
            BigInteger result = 0;

            for (int i = number.Length - 1; i >= 0; --i)
            {
                result += n * (number[i] - '0');
                n *= @base;
            }

            return result;
        }
    }
}
