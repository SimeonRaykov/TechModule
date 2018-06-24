using System;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int total = 0;
            int currentNumber = 0;
            bool magicNumber = false;
            for (int ch = 1; ch <= number; ch++)
            {
                currentNumber = ch;
                while (ch > 0)
                {
                    total += ch % 10;
                    ch = ch / 10;
                }
                magicNumber = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine($"{currentNumber} -> {magicNumber}");
                total = 0;
                ch = currentNumber;
            }



        }
    }
}
