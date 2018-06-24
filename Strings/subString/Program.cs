using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics;
namespace subString
{
    class Program
    {
        static void Main(string[] args)
        {

            string first= Console.ReadLine().ToLower();
            string second = Console.ReadLine().ToLower();
            int count = 0;
            int index = -1;
            while (true)
            {
                index = first.IndexOf(second, index+1);
                if (index == -1)
                {
                    break;
                }
                else
                {
                    count++;
                }

            }
            Console.WriteLine(count);
        }
    }
}
