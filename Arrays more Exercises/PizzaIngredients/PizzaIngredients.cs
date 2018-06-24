using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace PizzaIngredients
{
    class PizzaIngredients
    {
        static void Main(string[] args)
        {

            string[] ingredients = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int length = int.Parse(Console.ReadLine());
            int counter = 0;

            List<string> ingredientsAcceptable = new List<string>();

            for (int i = 0; i < ingredients.Length; i += 1)
            {

                if (ingredients[i].Length == length)
                {
                    ingredientsAcceptable.Add(ingredients[i]);
                    Console.WriteLine($"Adding {ingredients[i]}.");
                    counter += 1;
                }

                if (counter == 10)
                {

                    break;

                }



            }

            Console.WriteLine($"Made pizza with total of {counter} ingredients.");
            Console.WriteLine("The ingredients are: " + string.Join(", ", ingredientsAcceptable) + ".");



        }
    }
}
