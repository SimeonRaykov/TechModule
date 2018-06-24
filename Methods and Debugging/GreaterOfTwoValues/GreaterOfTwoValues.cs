using System;

namespace GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main(string[] args)
        {


            String chooseTypeOfValue = Console.ReadLine().ToLower();
            if (chooseTypeOfValue == "char")
            {
                char a = Char.Parse(Console.ReadLine());
                char b = Char.Parse(Console.ReadLine());
                Console.WriteLine(GreaterValue(a, b));
            }
            else if (chooseTypeOfValue == "string")
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                Console.WriteLine(GreaterValue(firstString, secondString));

            }
            else if (chooseTypeOfValue == "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                Console.WriteLine(GreaterValue(firstNumber, secondNumber));
            }


        }
        static char GreaterValue(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static int GreaterValue(int firstNumber, int secondNumber)
        {

            if (firstNumber >= secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }
        static string GreaterValue(string firstString, string secondString)
        {
         /*   if (firstString.Length > secondString.Length)
            {
                return firstString;
            }
            else
            {
                return secondString;*/

                if (firstString.CompareTo(secondString) >0)
                
                   return  firstString;
                
                
                else
                
                
                   return secondString;
                
                

            }
        }
    }

