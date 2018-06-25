using System;

namespace sumOfOddNumbers
{
    class sumOfOddNumbers
    {
        static void Main(string[] args)
        {
            int numberToCheck = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i <numberToCheck*2; i++)
            {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                    sum += i;

                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
