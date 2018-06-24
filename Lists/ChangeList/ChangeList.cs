using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ChangeList
{
    class ChangeList
    {
        static void Main(string[] args)
        {
            List<int> numberList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();


            List<string> commandS = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

      //      string command = commandS[0];

            while (commandS[0] != "Even" && commandS[0] != "Odd")
         {
             if (commandS[0] == "Delete")
             {
              
                 int numberz = int.Parse(commandS[1]);
                     numberList.RemoveAll(x => x == numberz);          
             }
             else if (commandS[0] == "Insert")
             {
                 int element= int.Parse(commandS[1]);
                 int position = int.Parse(commandS[2]);

              numberList.Insert(position,element);
             }

             commandS = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            if (commandS[0] == "Odd")
            {
                for (int i = 0; i <numberList.Count; i++)
                {
                    if (numberList[i] % 2 != 0)
                    {
                        Console.Write($"{numberList[i]} ");
                    }
                   
                }
            }
            else if (commandS[0] == "Even")
            {
                for (int i = 0; i < numberList.Count; i++)
                {
                    if (numberList[i] % 2 == 0)
                    {
                        Console.Write($"{numberList[i]} ");
                    }
                }
            }
        }
    }
}
