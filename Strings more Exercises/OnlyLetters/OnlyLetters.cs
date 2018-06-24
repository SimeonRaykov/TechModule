using System;
using System.Collections.Generic;
using System.Text;

namespace OnlyLetters
{
    class OnlyLetters
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();

            List<string> isNumber = new List<string>();

            for (int i = 0; i <= 9; i++)
            {
                var currentChaXr = i.ToString();
                isNumber.Add(currentChaXr);

            }

            var subString = "";
            var final = "";
            var replaced = "";

            StringBuilder sb=new StringBuilder();

            var currentChar = "";
            var nextChar = "";

            for (int i = 0; i < input.Length - 1; i++)
            {
                currentChar = input[i].ToString();
                nextChar = input[i + 1].ToString();
                
                if (isNumber.Contains(currentChar) == false)
                {
                    final += currentChar;
                }
                else if (isNumber.Contains(currentChar))
                {

                    subString += currentChar;
                    if (isNumber.Contains(nextChar) == false)
                    {
                    subString=subString.Replace(subString, nextChar);
                        final += subString;
                        subString = "";
                    }


                }
            }

            if (isNumber.Contains(input[input.Length - 1].ToString()) == false)
            {
                final += input[input.Length - 1];
            }


            else
            {


                var d = 1;

                while (isNumber.Contains(input[input.Length - d].ToString()))
                {
                    final += input[input.Length-d];
                    d+=1;

                }
            }

            Console.WriteLine(final);



        }
    }
}
