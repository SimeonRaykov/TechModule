using System;

namespace CircleArea12f
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = Double.Parse(Console.ReadLine());
            
            double circleArea = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"{circleArea:F12}");
        }
    }
}
