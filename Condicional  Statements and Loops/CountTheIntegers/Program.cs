using System;

namespace CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            try
            {
                

                for (int i = 0; i <= 100; i++)
                {
                    int input = int.Parse(Console.ReadLine());
                    count++;
                }

                
            }
            catch (Exception)
            {
                Console.WriteLine($"{count}");
                return;
            }    
        }
    }
}
