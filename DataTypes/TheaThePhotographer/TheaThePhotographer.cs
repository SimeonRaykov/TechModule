using System;
using System.Globalization;

namespace TheaThePhotographer
{
    class TheaThePhotographer
    {
        static void Main(string[] args)
        {
            double numberOfPictures = double.Parse(Console.ReadLine());
            double filterTime = double.Parse(Console.ReadLine());
            double filterFactorPercentage =double.Parse(Console.ReadLine());
            double timeForEachPic = double.Parse(Console.ReadLine());

            double filteredPics =  Math.Ceiling(numberOfPictures - (numberOfPictures * (100-filterFactorPercentage )/ 100));
            double filteredPicsTwo =numberOfPictures * filterTime;
            double filteredPicsThree = filteredPics * timeForEachPic;
            double totalTime = filteredPicsThree + filteredPicsTwo;
            string date = totalTime.ToString();
             date=ConvertSecondsToDate(date);
            Console.WriteLine(date);
           
        }
        static string ConvertSecondsToDate(string seconds)
        {
            TimeSpan t = TimeSpan.FromSeconds(Convert.ToDouble(seconds));
          return t.ToString(@"d\:hh\:mm\:ss");
            
        }
    }
}
