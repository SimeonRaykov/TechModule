using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int number = 0;
            int currentnumber = 0;
            for (int i = 1; i <= n; i++)
            {
                while (n>0)
                {
                    
                    sum += n / 10;
                    sum = sum / 10;
                
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");

                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }

            }


        }
    }
}
