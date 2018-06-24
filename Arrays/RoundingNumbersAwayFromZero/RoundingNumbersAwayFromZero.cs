using System;
using System.Linq;
namespace RoundingNumbersAwayFromZero
{
    class RoundingNumbersAwayFromZero
    {
        static void Main(string[] args)
        {
            String inputConsole = Console.ReadLine();
            double[] arrayOfNumbers = inputConsole
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(Double.Parse)
                .ToArray();

            for (int i = 0; i <arrayOfNumbers.Length; i++)
            {
                
                double rounded = Math.Round(arrayOfNumbers[i]
                    ,MidpointRounding
                    .AwayFromZero);

                Console.WriteLine(arrayOfNumbers[i]+" ==> "+""+rounded);
                                          

            }

       //TEST//  foreach (var item in arrayOfNumbers)
       //    //{
       //    // double rounded = Math.Round(item, MidpointRounding
       //    //     .AwayFromZero);
       //    // Console.WriteLine(item+" "+rounded);
       //    //
       //    //  }
        }
    }
}
