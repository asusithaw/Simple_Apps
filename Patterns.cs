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
            Console.Write("Enter the number of rows you want:");
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
            Console.Write("Enter the number of rows you want:");
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

        public void StarPatternX()
        {
            /*Console.Write("Enter the number of rows you want:");
            int x = Convert.ToInt32(Console.ReadLine());*/

            for (int i = 1; i < 6; i++)
            {
                if (i < 3)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(" ");

                    }
                    Console.Write("*");
                }
                else
                {
                    for (int j = 6 - i; j >= 1; j--)
                    {
                        Console.Write(" ");

                    }

                    Console.Write("*");
                }


                if (i < 3)
                {
                    for (int j = 6 - (2 * i); j >= 1; j--)
                    {
                        Console.Write(" ");

                    }

                    Console.Write("*");
                }
                else
                {
                    for (int j = 1; j <= i - 3; j++)
                    {
                        Console.Write(" ");

                    }
                    Console.Write("*");

                }

                Console.WriteLine();
            }



            /*
                        for (int i = 1; i < 13; i++)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write(" ");

                            }
                            Console.Write("*");

                            for (int j = 13 - (2 * i + 1); j >= 1; j--)
                            {
                                Console.Write(" ");

                            }
                            Console.Write("*");
                            Console.WriteLine();
                        }
            */



        }

        public void StarPatternXBy2DArray()
        {
            Console.Write("Enter the number of rows you want:");
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
            int m = x-1;
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
            Console.Write("Enter the number of rows you want:");
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
    }
}
