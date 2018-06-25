using System;

namespace sumOfOddNumbers2
{
    class RageExpenses
    {
        static void Main(string[] args)
        {

            float lostGames = float.Parse(Console.ReadLine());
            float headSetPrice = float.Parse(Console.ReadLine());
            float mousePrice=float.Parse(Console.ReadLine());
            float keyboardPrice=float.Parse(Console.ReadLine());
            float displayPrice=float.Parse(Console.ReadLine());

            float headCount = 0;
            float mouseCount = 0;
            float keyboardCount = 0;
            float displayCount = 0;

           

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    headCount++;
                }
                if (i % 3 == 0)
                {
                    mouseCount++;
                }
                if(i%2==0 && i % 3 == 0)
                {
                    keyboardCount++;
                }
                if (i % 12 == 0)
                {
                    displayCount++;
                }

            }
         //  Console.WriteLine(headCount * headSetPrice);
         //  Console.WriteLine(mouseCount * mousePrice);
         //  Console.WriteLine(keyboardCount * keyboardPrice);
         //  Console.WriteLine(headCount * headSetPrice);

            float sum = (headCount * headSetPrice)
                + (mouseCount * mousePrice)
                + (keyboardCount * keyboardPrice)
                + (displayPrice*displayCount);
            Console.WriteLine($"Rage expenses: {sum:F2} lv.");

        }
    }
}
