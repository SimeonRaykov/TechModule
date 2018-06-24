using System;
using System.Linq;

namespace sumArrays
{
    class sumArrays
    {
        static void Main(string[] args)
        {
            string One = Console.ReadLine();
            string Two = Console.ReadLine();
            int[] arrayOne = One
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int[] arrayTwo = Two
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int max = Math.Max(arrayOne.Length,arrayTwo
                .Length);
            int[] sum = new int[max];
            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = arrayOne[i % arrayOne.Length] 
                    + arrayTwo[i % arrayTwo.Length];
            }
       //     foreach (var item in sum)
       //     {
       //         Console.Write($"{item} ");
       //     }
            Console.WriteLine(string.Join(" ",sum));
        
         

        }
    }
}
