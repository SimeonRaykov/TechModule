using System;

namespace MultiplyEvensByOdds
{
    class MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(MultiplierOfOddAndEvenNumbers(number));


        }
        static int MultiplierOfOddAndEvenNumbers(int number)
        {
            number = Math.Abs(number);
            int evenSum = 0;
            int oddSum = 0;
            int lastDigit;
            while (number>0)
            {
                lastDigit = number % 10;
                if (number % 2 == 0)
                {
                    evenSum += lastDigit;
                }
                else
                {
                    oddSum += lastDigit;
                }
                number = number / 10;
                 
            }
            return oddSum * evenSum;
        }
    }
}
