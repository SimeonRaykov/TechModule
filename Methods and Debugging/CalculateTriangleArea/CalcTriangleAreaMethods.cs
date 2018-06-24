using System;

namespace CalculateTriangleArea
{
    class CalcTriangleAreaMethods
    {
        static void Main(string[] args)
        {

            double height = Double.Parse(Console.ReadLine());
            double width = Double.Parse(Console.ReadLine());
            double areaSize = TriangleArea(height,width);
            Console.WriteLine($"{areaSize}");

        }
        static double TriangleArea(double height, double width)
        {
            return height * width / 2;
        }
    }
}
