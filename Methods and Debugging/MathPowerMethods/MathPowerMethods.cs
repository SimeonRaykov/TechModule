using System;

namespace MathPowerMethods
{
    class MathPowerMethods
    {
        static void Main(string[] args)
        {
                  double number =double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
                  number = MathPowerMethodsOP(number, power);
                  Console.WriteLine($"{number}");    
        }

        static double MathPowerMethodsOP(double number,double power,double result=1)
        {
           
            for (double i =0; i < power; i++)
            {
          result *= number;
            }
            return result;
        }
    }
}
