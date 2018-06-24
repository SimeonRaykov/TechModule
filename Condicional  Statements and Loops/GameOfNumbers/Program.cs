using System;

namespace GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            int sum = 0;

            for (int i = m; i>= n; i--)
            {
                for (int j = m; j >=n; j--)
                {
                    counter++;
                    if (i + j == magicalNumber)
                    {

                        Console.WriteLine($"Number found! {i} + {j} = {magicalNumber}");
                        return;
                    }

                }
            }

            Console.WriteLine($"{counter} combinations - neither equals {magicalNumber}");


        }
    }
}
