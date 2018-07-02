using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoursePlanning
{
    class SoftUniCoursePlanning
    {
        static void Main(string[] args)
        {

            List<string> listOfItems = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

           var input = Console.ReadLine();

            while (input!="course start")
            {
                if (input.Contains("Add"))
                {
                    var tokens = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
                    var currentLessonTitle = tokens[1];
                    if (listOfItems.Contains(currentLessonTitle) == false)
                    {
                    listOfItems.Add(currentLessonTitle);

                    }
                }

                if (input.Contains("Insert"))
                {
                    var tokens = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
                    var currentLessonTitle = tokens[1];
                    var index = int.Parse(tokens[2]);

                    if (listOfItems.Contains(currentLessonTitle) == false)
                    {
                        if (index >= 0)
                        {
                        listOfItems.Insert(index,currentLessonTitle);

                        }
                    }
                }

                if (input.Contains("Remove"))
                {
                    var tokens = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
                    var currentLessonTitle = tokens[1];

                    if (listOfItems.Contains(currentLessonTitle))
                    {
                        listOfItems.Remove(currentLessonTitle);
                        if (listOfItems.Contains("Exercise" + "-" + currentLessonTitle))
                        {
                            listOfItems.Remove("Exercise" + "-" + currentLessonTitle);

                        }
                    } 
                }

                if (input.Contains("Exercise"))
                {
                    var tokens = input.Split(":",StringSplitOptions.RemoveEmptyEntries);
                    var currentLessonTitle = tokens[1];
                    var currentExercise = tokens[1]+"-"+"Exercise";

                    if (listOfItems.Contains(currentLessonTitle))
                    {
                        if (listOfItems.Contains(currentExercise) == false)
                        {

                            int index = listOfItems.IndexOf(currentLessonTitle);
                            listOfItems.Insert(index+1,currentExercise);


                        }

                    }
                    else if (listOfItems.Contains(currentLessonTitle) == false)
                    {
                        listOfItems.Add(currentLessonTitle);
                        listOfItems.Add(currentExercise);
                    }

                }

                if (input.Contains("Swap"))
                {

                    var tokens = input.Split(":",StringSplitOptions.RemoveEmptyEntries);

                    var firstLessonTitle = tokens[1];
                    var secondLessonTitle = tokens[2];

                    if (listOfItems.Contains(firstLessonTitle) && listOfItems.Contains(secondLessonTitle))
                    {
                        var firstIndex= listOfItems.IndexOf(firstLessonTitle);
                        var secondIndex= listOfItems.IndexOf(secondLessonTitle);

                        if (firstIndex < secondIndex)
                        {
                            listOfItems.Remove(firstLessonTitle);
                            listOfItems.Remove(secondLessonTitle);

                            listOfItems.Insert(firstIndex, secondLessonTitle);
                            listOfItems.Insert(secondIndex, firstLessonTitle);

                            if (listOfItems.Contains(firstLessonTitle + "-Exercise"))
                            {
                                listOfItems.Remove(firstLessonTitle + "-Exercise");
                                listOfItems.Insert(secondIndex+1, firstLessonTitle + "-Exercise");


                            }
                            if (listOfItems.Contains(secondLessonTitle + "-Exercise"))
                            {
                                listOfItems.Remove(secondLessonTitle + "-Exercise");
                                listOfItems.Insert(firstIndex + 1, secondLessonTitle + "-Exercise");

                            }

                        }
                        else
                        {
                            listOfItems.Remove(firstLessonTitle);
                            listOfItems.Remove(secondLessonTitle);

                            listOfItems.Insert(secondIndex, firstLessonTitle);
                            listOfItems.Insert(firstIndex, secondLessonTitle);


                            if (listOfItems.Contains(firstLessonTitle + "-Exercise"))
                            {
                                listOfItems.Remove(firstLessonTitle + "-Exercise");
                                listOfItems.Insert(secondIndex + 1, firstLessonTitle + "-Exercise");
                            }
                            if (listOfItems.Contains(secondLessonTitle + "-Exercise"))
                            {

                                listOfItems.Remove(secondLessonTitle + "-Exercise");
                                listOfItems.Insert(firstIndex + 1, secondLessonTitle + "-Exercise");
                            }


                        }




                    }


                }



                input = Console.ReadLine();
            }

            var i = 1;

            foreach (var item in listOfItems)
            {

                Console.WriteLine($"{i}.{item}");

                i++;
            }

        }
    }
}
