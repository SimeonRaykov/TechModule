using System;

namespace NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());
            int peshoHealth = 100;
            int goshoHealth = 100;
            int round = 0;

            while (goshoHealth>0 && peshoHealth>0)
            {
                round++;
             
               
                if (round % 2 != 0)
                {
              
                    goshoHealth -= peshoDamage;
                    if (peshoHealth <= 0 || goshoHealth <= 0)
                    {
                        break;
                    }
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                    
                }
                else if(round % 2 == 0)
                {
                  
                    peshoHealth -= goshoDamage;
                    if (peshoHealth <= 0 || goshoHealth <= 0)
                    {
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
               
                }
                if (round % 3 == 0)
                {
                    goshoHealth += 10;
                    peshoHealth += 10;
                }


            }
            if (peshoHealth > 0)
            {
                Console.WriteLine($"Pesho won in {round}th round.");
            }
            else
            {
                Console.WriteLine($"Gosho won in {round}th round.");
            }
            

        }
    }
}
