using System;
using System.Linq;

namespace ManipulateArray
{
    class ManipulateArray
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
            int n = int.Parse(Console.ReadLine());
            var inputCopy = new string[input.Length];
            for (int i = 0; i < n; i++)
            {
                string[]command = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (command[0] == "Distinct")
                {
                    input= input.Distinct().ToArray();
                }
                else if (command[0] == "Reverse")
                {
                    input = input.Reverse().ToArray();
                }
                else if (command[0] == "Replace")
                {
                    for (int j = 0; j < input.Length; j++)
                    {
                        
                        var commandX = int.Parse(command[1]);
                        input[commandX] = command[2];



                    }
                }



            }

            Console.WriteLine(
            string.Join(", ", input));
        }
    }
}
