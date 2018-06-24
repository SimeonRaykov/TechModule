using System;

namespace TemperatureConversion
{
    class TemperatureConversion
    {
        static void Main(string[] args)
        {
            double fahrenheit = Double.Parse(Console.ReadLine());
           fahrenheit= Fahrenheit(fahrenheit);
            Console.WriteLine($"{fahrenheit:F2}");

        }
        static double Fahrenheit(double degrees)
        {
 

            return degrees = (degrees - 32) * 5 / 9;
        }
    }
}
