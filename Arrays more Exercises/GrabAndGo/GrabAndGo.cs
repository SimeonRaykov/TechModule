using System;
using System.Linq;
using System.Linq.Expressions;

namespace GrabAndGo
{
    class GrabAndGo
    {
        static void Main(string[] args)
        {

            long[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(long.Parse)
                .ToArray();
        
               int n = int.Parse(Console.ReadLine());
                var index = 0;


                index = Array.LastIndexOf(numbers, n);

                if (index == -1)
                {
                    Console.WriteLine("No occurrences were found!");
                }
                else
                {
                    double sum = 0;

               //   for (int i = 0; i <= numbers[index] + 2; i++)
               //   {
               //       sum += numbers[i];
               //
               //   }

                    for (long i =index; i > 0; i--)
                    {
                        sum += numbers[i-1];
                    }

              //      Console.WriteLine(index);


                    Console.WriteLine(sum);
                }
            


        // catch (Exception e)
        // {
        //     Console.WriteLine("ok");
        // }
        }
    }
}
