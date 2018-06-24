using System;

namespace DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            TopAndBot(n);
            Middle(n);
            TopAndBot(n);

        }

        private static void TopAndBot(int n)
        {

            string topAndBot = new string('-', n * 2);
            Console.WriteLine(topAndBot);
        }
        static void Middle(int n)
        {

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("-");
                for (int j = 0; j < n - 1; j++)
                {

                    Console.Write(@"\/");
                }
                Console.WriteLine("-");
            }


        }
    }
}

