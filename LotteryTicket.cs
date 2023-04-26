using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    class LotteryTicket
    {
        public void AmountOfLotteryTicketWinning()
        {
            Console.WriteLine("Enter Winning Number:");
            string winningNumbersWithLetter = Console.ReadLine();

            Console.WriteLine("Enter Your Ticket Number:");
            string ticketNumberWithLetter = Console.ReadLine();

            string winningNumbersWithLetterSpaceRemoveStr = winningNumbersWithLetter.Replace(" ", "").ToLower();
            string ticketNumberWithLetterSpaceRemoveStr = ticketNumberWithLetter.Replace(" ", "").ToLower();

            if (winningNumbersWithLetterSpaceRemoveStr.Length == 7 || ticketNumberWithLetterSpaceRemoveStr.Length == 7)
            {

                //Letter and 6 Numbers Correct
                if (winningNumbersWithLetterSpaceRemoveStr == ticketNumberWithLetterSpaceRemoveStr)
                {
                    Console.WriteLine(CommonEndLine("Super Prize"));
                }

                //6 Numbers Correct
                else if (winningNumbersWithLetterSpaceRemoveStr.Substring(1) == ticketNumberWithLetterSpaceRemoveStr.Substring(1))
                {
                    Console.WriteLine(CommonEndLine("2,000,000.00"));
                }

                //Last 5 Numbers Correct
                else if (winningNumbersWithLetterSpaceRemoveStr.Substring(2) == ticketNumberWithLetterSpaceRemoveStr.Substring(2))
                {
                    Console.WriteLine(CommonEndLine("100,000.00"));
                }

                //Last 4 Numbers Correct
                else if (winningNumbersWithLetterSpaceRemoveStr.Substring(3) == ticketNumberWithLetterSpaceRemoveStr.Substring(3))
                {
                    Console.WriteLine(CommonEndLine("10,000.00"));
                }

                //First 5 Numbers Correct
                else if (winningNumbersWithLetterSpaceRemoveStr.Substring(1,5) == ticketNumberWithLetterSpaceRemoveStr.Substring(1,5))
                {
                    Console.WriteLine(CommonEndLine("10,000.00"));
                }

                //Last 3 Numbers Correct
                else if (winningNumbersWithLetterSpaceRemoveStr.Substring(4) == ticketNumberWithLetterSpaceRemoveStr.Substring(4))
                {
                    Console.WriteLine(CommonEndLine("1,000.00"));
                }

                //First 4 Numbers Correct
                else if (winningNumbersWithLetterSpaceRemoveStr.Substring(1,4) == ticketNumberWithLetterSpaceRemoveStr.Substring(1,4))
                {
                    Console.WriteLine(CommonEndLine("1,000.00"));
                }

                //Last 2 Numbers Correct
                else if (winningNumbersWithLetterSpaceRemoveStr.Substring(5) == ticketNumberWithLetterSpaceRemoveStr.Substring(5))
                {
                    Console.WriteLine(CommonEndLine("100.00"));
                }

                //First 3 Numbers Correct
                else if (winningNumbersWithLetterSpaceRemoveStr.Substring(1, 3) == ticketNumberWithLetterSpaceRemoveStr.Substring(1, 3))
                {
                    Console.WriteLine(CommonEndLine("100.00"));
                }

                //First 2 Numbers Correct
                else if (winningNumbersWithLetterSpaceRemoveStr.Substring(1, 2) == ticketNumberWithLetterSpaceRemoveStr.Substring(1, 2))
                {
                    Console.WriteLine(CommonEndLine("50.00"));
                }

                //Last Number Correct
                else if (winningNumbersWithLetterSpaceRemoveStr.Substring(6) == ticketNumberWithLetterSpaceRemoveStr.Substring(6))
                {
                    Console.WriteLine(CommonEndLine("20.00"));
                }

                //Letter Correct
                else if (winningNumbersWithLetterSpaceRemoveStr.Substring(0,1) == ticketNumberWithLetterSpaceRemoveStr.Substring(0,1))
                {
                    Console.WriteLine(CommonEndLine("20.00"));
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

        public string CommonEndLine(string amount)
        {
            return ($"You have won: Rs. {amount}");
        }



    }
}
