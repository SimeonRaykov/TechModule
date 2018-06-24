using System;
using System.Linq;

namespace SafeManipulator
{
    class SafeManipulator
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (commands[0] != "END")
            {
                if (commands[0] != "Distinct" && commands[0] != "Reverse" && commands[0] != "END"
                    && commands[0]!="Replace")
                {
                    Console.WriteLine("Invalid input!");
                }

                if (commands[0] == "Distinct")
                {
                    input = input.Distinct().ToArray();
                }
                else if (commands[0] == "Reverse")
                {
                    input = input.Reverse().ToArray();
                }
                else if (commands[0] == "Replace")
                {
                    if (int.Parse(commands[1]) >=0 && int.Parse (commands[1]) <= input.Length - 1)
                    {
                        for (int j = 0; j < input.Length; j++)
                        {

                            var commandX = int.Parse(commands[1]);
                            input[commandX] = commands[2];



                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    
                }



                commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }


            Console.WriteLine(
            string.Join(", ", input));

        }
    }
}
