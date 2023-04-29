using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    class LotteryTicketShanidaWasanawa
    {
        public void AmountOfLotteryTicketWinning()
        {
            Console.WriteLine("Enter Winning Number:");
            string winningNumbersWithLetter = Console.ReadLine().ToLower();

            Console.WriteLine("Enter Your Ticket Number:");
            string ticketNumberWithLetter = Console.ReadLine().ToLower();

            string winningNumbersWithLetterSpaceRemoveStr = winningNumbersWithLetter.Replace(" ", "");
            string ticketNumberWithLetterSpaceRemoveStr = ticketNumberWithLetter.Replace(" ", "");

            if (winningNumbersWithLetterSpaceRemoveStr.Length == 9 && ticketNumberWithLetterSpaceRemoveStr.Length == 9)
            {
                string[] winningNumbersWithLetterArray = winningNumbersWithLetter.Split(" ");
                string[] ticketNumberWithLetterArray = ticketNumberWithLetter.Split(" ");

                int count = 0;

                for (int i = 1; i < 5; i++)
                {
                    for (int j = 1; j < 5; j++)
                    {
                        if (winningNumbersWithLetterArray[i] == ticketNumberWithLetterArray[j])
                        {
                            count++;
                            break;
                        }
                    }
                }
                
                //Creating object of the Lottery Ticket class
                LotteryTicket lotteryTicket = new LotteryTicket();

                //4 Numbers & English letter
                if (winningNumbersWithLetterArray[0] == ticketNumberWithLetterArray[0] && count == 4)
                {
                    Console.WriteLine(lotteryTicket.CommonEndLine("Super Prize"));
                }

                //4 Numbers
                else if (winningNumbersWithLetterArray[0] != ticketNumberWithLetterArray[0] && count == 4)
                {
                    Console.WriteLine(lotteryTicket.CommonEndLine("1,000,000.00"));
                }

                //3 Numbers & English Letter
                else if (winningNumbersWithLetterArray[0] == ticketNumberWithLetterArray[0] && count == 3)
                {
                    Console.WriteLine(lotteryTicket.CommonEndLine("100,000.00"));
                }

                //3 Numbers
                else if (winningNumbersWithLetterArray[0] != ticketNumberWithLetterArray[0] && count == 3)
                {
                    Console.WriteLine(lotteryTicket.CommonEndLine("2,000"));
                }

                //2 Numbers & English Letter
                else if (winningNumbersWithLetterArray[0] == ticketNumberWithLetterArray[0] && count == 2)
                {
                    Console.WriteLine(lotteryTicket.CommonEndLine("1,000"));
                }

                //2 Numbers 
                else if (winningNumbersWithLetterArray[0] != ticketNumberWithLetterArray[0] && count == 2)
                {
                    Console.WriteLine(lotteryTicket.CommonEndLine("100.00"));
                }

                //1 Number & English Letter
                else if (winningNumbersWithLetterArray[0] == ticketNumberWithLetterArray[0] && count == 1)
                {
                    Console.WriteLine(lotteryTicket.CommonEndLine("100.00"));
                }

                //1 Number 
                else if (count == 1)
                {
                    Console.WriteLine(lotteryTicket.CommonEndLine("20.00"));
                }

                //1 English Letter 
                else if (winningNumbersWithLetterArray[0] == ticketNumberWithLetterArray[0])
                {
                    Console.WriteLine(lotteryTicket.CommonEndLine("20.00"));
                }

                else
                {
                    Console.WriteLine("Bad Luck Today, Try Again Another Day");
                }

            }

            else
            {
                Console.WriteLine("Enter valid amount of characters to proceed further");
            }
        }
    }
}
