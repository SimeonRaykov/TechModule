using System;

namespace ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = int.Parse(Console.ReadLine());
            decimal sum = 0;
            if (number == 1)
            {
                Console.WriteLine($"{number}");
                return;
            }
            for (int i = 1; i <= number; i++)
            {
                decimal currentnumber = decimal.Parse(Console.ReadLine());
                sum += currentnumber;
            }
            Console.WriteLine($"{sum}");


        }
    }
}
