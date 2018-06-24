using System;
using System.Linq;

namespace ArrayStatistics
{
    class ArrayStatistics
    {
        static void Main(string[] args)
        {

            double[] input = Console.ReadLine().Split().Select(Double.Parse).ToArray();

            Console.WriteLine("Min = "+input.Min());
            Console.WriteLine("Max = "+input.Max());
            Console.WriteLine("Sum = "+input.Sum());
            Console.WriteLine("Average = "+input.Average());



        }
    }
}
