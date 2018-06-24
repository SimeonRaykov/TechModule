using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {

            String month = Console.ReadLine();
            double nights = Double.Parse(Console.ReadLine());
            double discount = 0;
            double studio = 0;
            double doubleX = 0;
            double suite = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studio = 50;
                    doubleX = 65;
                    suite = 75;
                    break;
                case "June":
                case "September":
                    studio = 60;
                    doubleX = 72;
                    suite = 82;
                    break;
                case "July":
                case "August":
                case "December":
                    studio = 68;
                    doubleX = 77;
                    suite = 89;
                    break;
                default:
                    break;
            }
            if((month == "May" || month == "October") && (nights > 7))
            {
                discount = 5;
                studio = studio - (discount/100 * studio);

            }
             if ((month == "June" || month == "September") && (nights > 14))
            {
              discount = 10;
              doubleX = doubleX - (discount / 100 * doubleX);
            }
            if ((month == "July" || month == "August" || month == "December") && (nights > 14))
            {
                discount = 15;
                suite = suite - (discount / 100 * suite);
            }
             if((month=="September"|| month=="October") && (nights > 7))
            {
                //one night free
                studio = studio * (nights-1);
                doubleX = doubleX * nights;
                suite = suite * nights;

                Console.WriteLine($"Studio: {studio:F2} lv.");
                Console.WriteLine($"Double: {doubleX:F2} lv.");
                Console.WriteLine($"Suite: {suite:F2} lv.");
                return;
            }

            studio = studio * nights;
            doubleX = doubleX * nights;
            suite = suite * nights;


            Console.WriteLine($"Studio: {studio:F2} lv.");
            Console.WriteLine($"Double: {doubleX:F2} lv.");
            Console.WriteLine($"Suite: {suite:F2} lv.");
        }



    }
}

