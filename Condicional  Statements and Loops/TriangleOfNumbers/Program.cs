﻿using System;

namespace TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                for (int j = 0; j <i; j++)
                {
                  
                    if (count <= n)
                    {
                        Console.Write($"{count} ");
                        count++;
                    }
                    else
                    {
                        break;
                    }
                    
                }
                Console.WriteLine();
            }
            




        }
    }
}
