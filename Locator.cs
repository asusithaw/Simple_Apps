using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    class Locator
    {
        // In here, users are adding values by themselves. 
        public void LocateByValue()
        {
            Console.WriteLine("Enter your X coordinates as a number");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Y coordinates as a number");
            int y = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Please adhere to the following instructions; " + "\n" +
                "Press \"L\" to move Left" + "\n" +
                "Press \"R\" to move Right" + "\n" +
                "Press \"U\" to move Up" + "\n" +
                "Press \"D\" to move Down" + "\n" +
                "Press Anything to get rid of the program" + "\n"
                );

            string instruction = Console.ReadLine().ToUpper();

            switch (instruction)
            {
                case "L":
                    Console.WriteLine("You move to the Left");
                    x--;
                    break;

                case "R":
                    Console.WriteLine("You move to the Right");
                    x++;
                    break;

                case "U":
                    Console.WriteLine("You move to the Up");
                    y++;
                    break;

                case "D":
                    Console.WriteLine("You move to the Down");
                    y--;
                    break;

                default:
                    Console.WriteLine("Exiting the program");
                    break;
            }

            Console.WriteLine($"Your coordinates are ({x} {y})");
        }

        // In here, the values are passed through a function.
        public void LocateByValue(string text)
        {
            string[] words = text.Split(' ');

            string instruction = words[0];

            int count = Convert.ToInt32(words[1]);

            Console.WriteLine("Enter your X coordinates as a number");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Y coordinates as a number");
            int y = Convert.ToInt32(Console.ReadLine());

            switch (instruction)
            {
                case "L":
                    Console.WriteLine($"You move {count} steps to the Left");
                    for (int k = 0; k < count; k++)
                    {
                        x--;
                    }
                    break;

                case "R":
                    Console.WriteLine($"You move {count} steps to the Right");
                    for (int k = 0; k < count; k++)
                    {
                        x++;
                    }
                    break;

                case "U":
                    Console.WriteLine($"You move {count} steps to the Up");
                    for (int k = 0; k < count; k++)
                    {
                        y++;
                    }
                    break;

                case "D":
                    Console.WriteLine($"You move {count} steps to the Down");
                    for (int k = 0; k < count; k++)
                    {
                        y--;
                    }
                    break;

                default:
                    Console.WriteLine("Exiting the program");
                    break;
            }

            Console.WriteLine($"Your coordinates are ({x} {y})");

        }

        // In here, we are getting values through text file.
        public void LocateByFile()
        {
            Console.WriteLine("Enter your X coordinates as a number");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Y coordinates as a number");
            int y = Convert.ToInt32(Console.ReadLine());

            // Read a text file line by line.
            string[] lines = File.ReadAllLines(@"D:\ASP.net\Assignment_01\TextFile1.txt");

            foreach (string line in lines)
            {
                string[] words = line.Split(' ');

                string instruction = words[0];

                int count = Convert.ToInt32(words[1]);


                switch (instruction)
                {
                    case "L":
                        Console.WriteLine($"You move {count} steps to the Left");
                        for (int k = 0; k < count; k++)
                        {
                            x--;
                        }
                        break;

                    case "R":
                        Console.WriteLine($"You move {count} steps to the Right");
                        for (int k = 0; k < count; k++)
                        {
                            x++;
                        }
                        break;

                    case "U":
                        Console.WriteLine($"You move {count} steps to the Up");
                        for (int k = 0; k < count; k++)
                        {
                            y++;
                        }
                        break;

                    case "D":
                        Console.WriteLine($"You move {count} steps to the Down");
                        for (int k = 0; k < count; k++)
                        {
                            y--;
                        }
                        break;

                    default:
                        Console.WriteLine("Exiting the program");
                        break;
                }

            }
            Console.WriteLine($"Your coordinates are ({x} {y})");
        }
    }
}
