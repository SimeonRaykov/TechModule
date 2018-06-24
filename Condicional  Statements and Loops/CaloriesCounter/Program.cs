﻿using System;

namespace CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int calories = 0;
            for (int i = 0; i < n; i++) {
                String product = Console.ReadLine().ToLower();
                if (product == "cheese")
                {
                    calories += 500;
                }
           else  if(product=="tomato sauce")
                {
                    calories += 150;
                }
          else    if(product=="salami")
                {
                    calories += 600;
                }
            else    if (product=="pepper")
                {
                    calories += 50;
                }
             
            }
            
            Console.WriteLine($"Total calories: {calories}");


        }
    }
}
