using System;

namespace IntegerHexToBinary
{
    internal class IntegerHexToBinary
    {
        private static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string hexa = number.ToString("X");
            string binary = Convert.ToString(number, 2);
            Console.WriteLine(hexa);
            Console.WriteLine(binary);


        }


    }
}
