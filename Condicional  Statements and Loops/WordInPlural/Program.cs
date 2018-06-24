using System;

namespace WordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            String word = Console.ReadLine();

            if ((word.EndsWith("ch")) || (word.EndsWith("o"))
                    || (word.EndsWith("z")) || (word.EndsWith("sh")
            ) || (word.EndsWith("x")) || (word.EndsWith("sh")) ||
            (word.EndsWith("s")))
            {
                word += "es";
               

            }
          else  if (word.EndsWith("y"))
            {
               word= word.Replace("y", "ies");
                

                
            }
            else
            {
                word += "s";
                
            }

            Console.WriteLine(word);



        }
    }
}
