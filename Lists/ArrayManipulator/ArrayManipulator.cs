using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            List<int> listNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            List<string> command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            while (command[0] != "print")
            {
                if (command[0] == "add")
                {
                    int index =int.Parse(command[1]);
                    int element = int.Parse(command[2]);
                    listNumbers.Insert(index, element);
                }
                else if (command[0] == "addMany")

                {
                    int index = int.Parse(command[1]);
                    listNumbers.InsertRange(index, command.Skip(2).Select(int.Parse));
                }
                else if (command[0] == "contains")
                {
                    int element = int.Parse(command[1]);
                    if (listNumbers.Contains(element))
                    {
                        Console.WriteLine(listNumbers.IndexOf(element));
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }
               
                else if (command[0] == "shift")
                {
                    int position = int.Parse(command[1]) % listNumbers.Count;
                    var helper = listNumbers.Skip(position).ToList();
                    for (int i = 0; i < position; i++)
                    {
                        helper.Add(listNumbers[i]);
                    }
                    listNumbers = helper;
                }
                else if (command[0] == "sumPairs")
                {
                    int cycles = listNumbers.Count;
                    for (int i = 0; i < cycles/2; i++)
                    {
                        listNumbers[i] += listNumbers[i + 1];
                        listNumbers.RemoveAt(i+1);
                    }
                }
                else if (command[0] == "remove")
                {
                    int index=int.Parse(command[1]);
                    listNumbers.RemoveAt(index);
                }
                command= Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            Console.Write("[");
            Console.Write(string.Join(", ",listNumbers));
            Console.Write("]");
        }
    }

}
