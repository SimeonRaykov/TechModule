using System;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            String package = Console.ReadLine();
            String hall = "";
            double discount = 0;
            double totalsum = 0;
            double porcent = 0;

            if (groupSize > 120)
            {
                Console.WriteLine
                    ("We do not have an appropriate hall.");
                return;
            }
            if(groupSize<=50 && groupSize >= 0)
            {
                hall += "Small Hall";
              
            }
            else if(groupSize>=51 && groupSize <= 100)
            {
                hall += "Terrace";
            }
            else if(groupSize>=101 && groupSize <= 120)
            {
                hall += "Great Hall";
            }

            if (package == "Normal")
            {
                discount = 500;
                porcent = 5;
            }
            else if (package == "Gold")
            {
                discount = 750;
                porcent = 10;
            }
            else if (package == "Platinum")
            {
                discount = 1000;
                porcent = 15;
            }

            if(hall=="Small Hall")
            {
                totalsum = 2500 + discount;
                totalsum = totalsum - (totalsum * porcent / 100);
            }
            else if (hall == "Terrace")
            {
                totalsum = 5000 + discount;
                totalsum = totalsum - (totalsum * porcent / 100);
            }
            else if(hall=="Great Hall")
            {
                totalsum = 7500 + discount;
                totalsum = totalsum - (totalsum * porcent / 100);
            }
            double priceperson = totalsum / groupSize;

            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {priceperson:F2}");
        }
    }
}
