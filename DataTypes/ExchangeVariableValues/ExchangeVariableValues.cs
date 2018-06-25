using System;

namespace ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int oldA = a;
            int oldB = b;
             a = b;
            b = oldA;
            
            

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {oldA}");
            Console.WriteLine($"b = {oldB}");
            Console.WriteLine("After:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {oldA}");
                

        }
    }
}
