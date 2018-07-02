using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace RegexExercise
{
    class RegexExercise
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();


            var pattern = @"(%([A-Z]{1}[a-z]+)%)[^|$%.]*(<(\w+)>)[^|$%.]*\|([\d]+)\|([^|$%.]*([\d]+)(.[\d]+)*)\$";
            Regex regex = new Regex(pattern);

            var totalSum = 0M;

            while (input != "end of shift")
            {
                if (regex.IsMatch(input))
                {
                    Match match = regex.Match(input);

                    var name = match.Groups[2];
                    var product = match.Groups[4];
                    var count = match.Groups[5].ToString();
                    var price = match.Groups[6].ToString();
                  


                    bool startsWithDigit = false;

                    while (true)
                    {
                        if (price[0].ToString() != "0" && price[0].ToString() != "1" && price[0].ToString() != "2" && price[0].ToString() != "3" && price[0].ToString() != "4" && price[0].ToString() != "5" && price[0].ToString() != "6" && price[0].ToString() != "7"&&price[0].ToString() != "8" && price[0].ToString() != "9")
                            
                        {
                            price = price.Remove(0, 1);
                        }
                        else
                        {
                            startsWithDigit = true;
                            break;
                        }


                    }

                    var countConverted = decimal.Parse(count);
                    var priceConverted = decimal.Parse(price);
 

                    Console.WriteLine($"{name}: {product} - {countConverted*priceConverted:f2}");

                    totalSum += countConverted * priceConverted;




                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalSum:f2}");



        }
    }
}
