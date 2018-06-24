using System;

namespace Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            String profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double product = 0;
            
            switch (profession)
            {
                case "Athlete":
                
                    product = 0.7;
                    break;
                case "Businessman":
                case "Businesswoman":product = 1.00;
                
                    break;
                case "SoftUni Student":
                    product = 1.70;
                

                    break;

                default:
                    product = 1.20;
                   
                    break;
            }
            double sum = quantity * product;
            Console.WriteLine($"The {profession} has to pay {sum:F2}.");

            
        }
    }
}
