using System;

namespace FastPrimeChecker
{
    class FastPrimeChecker
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                bool isPrime = true;
                for (int residue = 2; residue <= Math.Sqrt(i); residue++)
                {
                    if (i % residue == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isPrime}");
            }




        }
    }
}
