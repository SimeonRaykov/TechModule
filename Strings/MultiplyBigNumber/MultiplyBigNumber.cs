using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace MultiplyBigNumber
{
    class MultiplyBigNumber
    {
        static void Main(string[] args)
        {

            string firstNumber = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier == 0) 
            {
                Console.WriteLine(0);
                return;
            }

            int reminder = 0;
            var currentSum = 0;

            StringBuilder sb=new StringBuilder();

            for (int i = firstNumber.Length- 1; i >= 0; i--)
            {
                int currentFirstDigit = int.Parse(firstNumber[i].ToString());
               
                 currentSum += currentFirstDigit * multiplier + reminder;

                reminder = currentSum / 10;
                sb.Append(currentSum % 10);

            }

         //   sb.Append(reminder);
            string output = sb.ToString().TrimStart('0');


            for (int i = output.Length- 1; i >= 0; i--)
            {

                Console.WriteLine(output[i]);
            }

        }

    }
}
