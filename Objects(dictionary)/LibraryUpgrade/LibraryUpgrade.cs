using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace LibraryUpgrade
{
    class LibraryUpgrade
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Dictionary<string, DateTime> bookTitleDictionary
                = new Dictionary<string, DateTime>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var bookTitle = tokens[0];
                DateTime currentDate = DateTime
                    .ParseExact(tokens[3], "dd.MM.yyyy"
                        , CultureInfo.InvariantCulture);

                if (bookTitleDictionary.ContainsKey(bookTitle) == false)
                {
                    bookTitleDictionary.Add(bookTitle, currentDate);
                }
                else
                {
                    bookTitleDictionary[bookTitle] = currentDate;
                }



            }

            var date = Console.ReadLine();
            var parsedDate = DateTime.ParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var finalDate = "";

            foreach (var bookTitle in bookTitleDictionary.OrderBy(x=>x.Value).ThenBy(y=>y.Key))
            {
                var currentDate = bookTitle.Value;

                if (parsedDate < currentDate)
                {

                    finalDate = currentDate.ToString("dd.MM.yyyy");

                    Console.WriteLine($"{bookTitle.Key} -> {finalDate}");
                }

            }





        }
    }
}
