using System;

namespace CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            String command = Console.ReadLine();
            int count = 0;
         
            while (command!="Bake!")
            {

                Console.WriteLine($"Adding ingredient {command}.");
                command=Console.ReadLine();
                count++;
                
                if (command == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {count} ingredients.");
                    return;
                }
               
                    
                    
                
            }


        }
    }
}
