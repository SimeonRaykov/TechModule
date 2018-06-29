using System;
using System.Text.RegularExpressions;

namespace ConsoleApp3
{
    class SnowFlake
    {
        static void Main(string[] args)
        {

            var surface = @"[^\dA-Za-z]+";
            var surface1 = @"^[^\dA-Za-z]+$";
            var mantle = @"[\d_]+";
            var mantle1 = @"^[\d_]+$";
            var core = @"[A-Za-z]+";

            Regex surfaceRegex = new Regex(surface);
            Regex surface1Regex = new Regex(surface1);
            Regex mantleRegex = new Regex(mantle);
            Regex mantle1Regex = new Regex(mantle1);
            Regex coreRegex = new Regex(core);


            var first = Console.ReadLine();
            var second = Console.ReadLine();
            var mid = Console.ReadLine();
            var fourth = Console.ReadLine();
            var fifth = Console.ReadLine();

            Match matchUno = surface1Regex.Match(first);
            Match matchDos = mantle1Regex.Match(second);
            Match matchTres1 = surfaceRegex.Match(mid);
            Match matchTres2 = mantleRegex.Match(mid);
            Match matchTres3 = coreRegex.Match(mid);
            Match matchCuatro = mantle1Regex.Match(fourth);
            Match matchCinco = surface1Regex.Match(fifth);

            var counter = 0;

            bool isMatch = false;
            bool isMatch1 = false;
            bool isMatch2 = false;
            bool isMatch3 = false;
            bool isMatch4 = false;
            bool isMatch5 = false;
            bool isMatch6 = false;
            bool isMatch7 = false;
            bool isMatch8 = false;



            if (matchUno.Success)
            {
                isMatch = true;
                if (matchDos.Success)
                {
                    isMatch1 = true;

                    if (matchCuatro.Success)
                    {
                        isMatch2 = true;

                        if (matchCinco.Success)
                        {
                            isMatch3 = true;

                            if (matchTres1.Success)
                            {
                                isMatch4 = true;
                                mid = mid.Replace(matchTres1.ToString(), "");

                                if (matchTres2.Success)
                                {
                                    isMatch5 = true;
                                    mid = mid.Replace(matchTres2.ToString(), "");

                                    if (matchTres3.Success)
                                    {

                                        isMatch6 = true;
                                        counter = matchTres3.Length;
                                        mid = mid.Replace(matchTres3.ToString(), "");

                                        if (matchTres2.Success)
                                        {
                                            isMatch7 = true;
                                            mid = mid.Replace(matchTres2.ToString(), "");

                                            if (matchTres1.Success)
                                            {
                                                isMatch8 = true;

                                                mid = mid.Replace(matchTres1.ToString(), "");

                                                if (counter == 0)
                                                {
                                                    Console.WriteLine("Invalid");
                                                    return;
                                                }
                                                bool isMatch9 = isMatch && isMatch1 && isMatch2 && isMatch3 &&
                                                                isMatch4 && isMatch5 && isMatch6 && isMatch7 && isMatch8;

                                                if (isMatch9)
                                                {
                                                    Console.WriteLine("Valid");
                                                    Console.WriteLine(counter);

                                                }



                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid");
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid");
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Invalid");
                                }

                            }
                            else
                            {
                                Console.WriteLine("Invalid");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Invalid");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                    }


                }
                else
                {
                    Console.WriteLine("Invalid");
                }


            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }
    }
}
