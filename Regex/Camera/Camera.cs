using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Camera
{
    class Camera
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var mToSkip = numbers[0];
            var nToTake = numbers[1];

            var final = "";

            var sum = mToSkip + nToTake;

            string pattern = @"(?<=\|<)[A-Za-z]{" + $"{sum}" + "}";

            var input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            var succesfulMatch = Regex.Matches(input, pattern);

            var matchedCameras = succesfulMatch
                .Select(a => a.Value.Trim())
                .ToArray();

            List<char[]> finalCameras = new List<char[]>();

            StringBuilder sb = new StringBuilder();

            foreach (var camera in matchedCameras)
            {

                var newCamera = camera.ToCharArray();
                newCamera = newCamera.Skip(mToSkip).ToArray();

                for (int i = 0; i < nToTake; i++)
                {
                    if (newCamera[i] == '|')
                    {

                        break;
                    }

                    final += newCamera[i].ToString();
                    sb.Append(final);

                    final = "";

                }

                sb.Append(", ");


            }

            if (sb.Length != 0)
            {
                if (sb[sb.Length - 1] == ',')
                {
                    sb.Remove(sb.Length - 1, 2);
                }

                if (sb[sb.Length - 1] == ',')
                {
                    sb.Remove(sb.Length - 1, 2);
                }

                if (sb[sb.Length - 2] == ',')
                {
                    sb.Remove(sb.Length - 2, 2);
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
