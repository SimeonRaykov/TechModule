using System;

namespace RefactorPyramidVolume
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;
            double width;
            double Height = 0;
            double Volume = 0;
            Console.Write("Length: ");
            length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            Height = double.Parse(Console.ReadLine());
            Volume = length*width*Height/3  ;
            Console.WriteLine("Pyramid Volume: {0:F2}", Volume);

        }
    }
}
