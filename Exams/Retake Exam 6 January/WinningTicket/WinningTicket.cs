using System;
using System.Linq;

namespace WinningTicket
{
    class WinningTicket
    {
        static void Main(string[] args)
        {

            string[] tickets = Console.ReadLine().Split(" ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            foreach (var ticket in tickets)
            {
                if (ticket.Length == 20)
                {
                    var firstHalf = ticket.Take(10).ToArray();
                    var secondHalf = ticket.Skip(10).Take(10).ToArray();

                    var counterLeft = 0;
                    var counterRight = 0;
                    var bestSeqLeft = 0;
                    var bestSeqRight = 0;
                    var currentSymbol = "";
                    var bestSymbolLeft = "";
                    var bestSymbolRight = "";
                    var matchSymbolLeft = firstHalf[0].ToString();
                    var matchSymbolRight = secondHalf[0].ToString();


                    for (int i = 0; i < firstHalf.Length; i++)
                    {
                        currentSymbol = firstHalf[i].ToString();


                        if (currentSymbol == "$" || currentSymbol == "#"
                                                 || currentSymbol == "@" || currentSymbol == "^")
                        {
                            counterLeft += 1;
                            if (currentSymbol != matchSymbolLeft)
                            {
                                counterLeft = 1;
                                matchSymbolLeft = currentSymbol;
                            }

                            if (counterLeft > bestSeqLeft)
                            {
                                bestSeqLeft = counterLeft;
                                bestSymbolLeft = currentSymbol;
                                matchSymbolLeft = currentSymbol;
                            }


                        }
                        else
                        {
                            counterLeft = 1;
                        }


                    }


                    for (int i = 0; i < secondHalf.Length; i++)
                    {
                        currentSymbol = secondHalf[i].ToString();


                        if (currentSymbol == "$" || currentSymbol == "#"
                                                 || currentSymbol == "@" || currentSymbol == "^")
                        {
                            counterRight += 1;

                            if (currentSymbol != matchSymbolRight)
                            {
                                counterRight = 1;
                                matchSymbolRight = currentSymbol;
                            }


                            if (counterRight > bestSeqRight)
                            {
                                bestSeqRight = counterRight;
                                bestSymbolRight = currentSymbol;
                                matchSymbolRight = currentSymbol;
                            }


                        }
                        else
                        {
                            counterRight = 1;
                        }


                    }

                    if (bestSeqRight == bestSeqLeft
                        && bestSymbolLeft == bestSymbolRight
                        && bestSeqRight >= 6)
                    {


                        if (bestSeqRight == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - 10{bestSymbolLeft} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {bestSeqLeft}{bestSymbolRight}");
                        }


                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match ");
                    }

                }
                else
                {
                    Console.WriteLine($"invalid ticket");
                }

            }

        }
    }
}
