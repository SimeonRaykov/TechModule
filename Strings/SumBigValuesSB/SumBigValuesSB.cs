using System;
using System.Text;

namespace SumBigValuesSB
{
    class SumBigValuesSB
    {
        static void Main(string[] args)
        {
            var firstNumber = Console.ReadLine();
            var secondNumber = Console.ReadLine();

            int[] sum = addTwoNumbers(firstNumber, secondNumber);
            Console.WriteLine(string.Join("",sum).TrimStart('0'));
        }

        private static void PrintSumOfTwoValues( string firstNumber,  string secondNumber)
        {
            StringBuilder sb = new StringBuilder();

            int n1 = firstNumber.Length;

            int n2 = secondNumber.Length;

            int carry = 0;

            int n = (n1 > n2) ? n1 : n2;

            if (n1 > n2)

                secondNumber = secondNumber.PadLeft(n1, '0');

            else

                firstNumber = firstNumber.PadLeft(n2, '0');

            for (int i = n - 1; i >= 0; i--)

            {

                int value = (carry + firstNumber[i] - 48 + secondNumber[i] - 48) % 10;

                sb.Append(value);

                carry = (carry + firstNumber[i] - 48 + secondNumber[i] - 48) / 10;

            }

            char[] c = sb.ToString().ToCharArray();

            Array.Reverse(c);

            Console.WriteLine(c);
        }
        public static int[] addTwoNumbers(string s1, string s2)
        {

            char[] num1 = s1.ToCharArray();
            char[] num2 = s2.ToCharArray();
            int sum = 0;
            int carry = 0;
            int size = (s1.Length > s2.Length) ? s1.Length + 1 : s2.Length + 1;
            int[] result = new int[size];
            int index = size - 1;
            int num1index = num1.Length - 1;
            int num2index = num2.Length - 1;


            while (true)
            {
                if (num1index >= 0 && num2index >= 0)
                {
                    sum = (num1[num1index] - '0') + (num2[num2index] - '0') + carry;
                }
                else if (num1index < 0 && num2index >= 0)
                {
                    sum = (num2[num2index] - '0') + carry;
                }
                else if (num1index >= 0 && num2index < 0)
                {
                    sum = (num1[num1index] - '0') + carry;
                }
                else { break; }


                carry = sum / 10;
                result[index] = sum % 10;
                index--;
                num1index--;
                num2index--;
            }

            if (carry > 0)
            {
                result[index] = carry;
            }


            return result;
        }
    }
}

