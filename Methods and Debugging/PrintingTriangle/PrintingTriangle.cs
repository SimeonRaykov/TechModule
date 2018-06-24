using System;
namespace Printingtriangle
{

}
class Program
{
    static void Main(string[] args)
    {
        PrintTriangle();

    }

    private static void PrintTop(int number)
    {
        for (int row = 1; row <= number; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write($"{col} ");

            }
            Console.WriteLine();
        }
    }

    private static void PrintBot(int number)
    {
        for (int row = number - 1; row >= 1; row--)
        {
            for (int col = 1; col <= row; col++)
            {

                Console.Write($"{col} ");
            }
            Console.WriteLine();

        }
    }
    static void PrintTriangle()
    {
        int number = int.Parse(Console.ReadLine());
        PrintTop(number);
        PrintBot(number);
    }
}


    

