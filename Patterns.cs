using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    class Patterns
    {
        public void StarPatternBackSlash()
        {
            Console.Write("Enter Size: ");
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");

                }
                Console.Write("*");
                Console.WriteLine();
            }
        }

        public void StarPatternForwardSlash()
        {
            Console.Write("Enter Size: ");
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = x; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write(" ");

                }
                Console.Write("*");
                Console.WriteLine();
            }
        }

        

        public void StarPatternXBy2DArray()
        {
            Console.Write("Enter Size: ");
            int x = Convert.ToInt32(Console.ReadLine());

            char[,] starPatternXArray = new char[x, x];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    starPatternXArray[i, j] = ' ';

                }

            }

            //BackSlash
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if (i == j)
                    {
                        starPatternXArray[i, j] = '*';
                    }
                }
            }

            //ForwardSlash
            int k = 0;
            int m = x - 1;
            while (m >= 0)
            {
                starPatternXArray[k, m] = '*';
                m--;
                k++;
            }

            //To print the Star Pattern 'X'
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {

                    Console.Write(starPatternXArray[i, j]);
                }
                Console.WriteLine();
            }

        }

        public void StarPatternTriangle()
        {
            Console.Write("Enter Size: ");
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                for (int j = x - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i - 1; j++)
                {
                    Console.Write("*");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }


        }

        public void MergeAllPatterns()
        {
            bool exitProgram = true;
            while (exitProgram)
            {              
                Console.WriteLine(
                "Menu" + "\n" +
                "1 - /" + "\n" +
                "2 - \\" + "\n" +
                "3 - X" + "\n" +
                "4 - Xmas tree" + "\n" +
                "O - Exit"
                );

                Console.Write("What do you want to print? ");
                string input = Console.ReadLine();

                if (input == "1" || input == "2" || input == "3" || input == "4")
                {                    

                    switch (input)
                    {
                        case "1":
                            StarPatternBackSlash();
                            break;

                        case "2":
                            StarPatternForwardSlash();
                            break;

                        case "3":
                            StarPatternXBy2DArray();
                            break;

                        case "4":
                            StarPatternTriangle();
                            break;
                            
                    }

                }
                else if (input == "0")
                {
                    Console.WriteLine("Exited From The Program");
                    exitProgram = false;
                }
                else
                {
                    Console.WriteLine($"Invalid input: {input}");
                }

            }

        }
    }
}
