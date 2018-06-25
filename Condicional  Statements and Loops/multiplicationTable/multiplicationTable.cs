using System;

namespace multiplicationTable
{
    class multiplicationTable
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
                

            }
            Console.WriteLine(isPrime);

           
       
        }
        static int Sum(int number)
        {
            int a;
            return a + a;
     

        }
    }
}
