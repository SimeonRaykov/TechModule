using System;

namespace IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int number1 = int.Parse(Console.ReadLine());

            

            for (int i = Math.Min(number,number1); i <= Math.Max(number1,number); i++)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}
