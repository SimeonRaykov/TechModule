using System;
using System.Linq;

namespace ReverseAnArrayOfIntegers
{
    class ReverseAnArrayOfIntegers
    {
        static void Main(string[] args)
        {

            int counterOfNumbersInArray = int.Parse(Console.ReadLine());
            int[] arrayOfNumbers = new int[counterOfNumbersInArray];

            for (int i = 0; i < counterOfNumbersInArray; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                arrayOfNumbers[i] = currentNumber;
       
            }
                    int[] reversedArrayOfNumbers = arrayOfNumbers
                .Reverse()
                .ToArray();
//Print This

      //     for (int i = 0; i < reversedArrayOfNumbers.Length; i++)
      //     {
      //         Console.WriteLine(reversedArrayOfNumbers[i]);
      //     }

            //Or this 
             
            foreach (var item in reversedArrayOfNumbers)
            {
                Console.WriteLine($"{item}");
            }

        }
    }
}
