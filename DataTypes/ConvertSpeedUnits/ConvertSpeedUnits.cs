using System;

namespace ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
           double distanceInMeters = double.Parse(Console.ReadLine());
           double hours = double.Parse(Console.ReadLine());
           double minutes = double.Parse(Console.ReadLine());
           double seconds = double.Parse(Console.ReadLine());
           double time = seconds + minutes * 60 + hours * 60 * 60;

            double mpS = distanceInMeters/time;
            double kmH = mpS * 3.6;
            double mpH = distanceInMeters / 1609 / time * 3600;
            Console.WriteLine($"{mpS:0.######}");
           Console.WriteLine($"{kmH:0.######}");
           Console.WriteLine($"{mpH:0.######}");

        }
    }
}
