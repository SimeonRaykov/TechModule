using System;

namespace specialNumbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
            int currentNumber = 0;

            for (int i = 1; i <= n; i++)
            {
                currentNumber = i;
                while (currentNumber > 0)
                {

                    sum += currentNumber % 10;
                    currentNumber = currentNumber / 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", i, isSpecial);
                // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                sum = 0;
        
// !!!!!!!!!!!!! Reset the sum to zero !!!!!!!!!!!!!!!!!!

            }
        }
    }
}
