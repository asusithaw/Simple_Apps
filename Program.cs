using System;

namespace Assignment_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******1. University Grading System******");
            UniversityGradingSystem();
            Console.WriteLine();

            Console.WriteLine("******2. BMI Calculator******");
            BMICalculator();
            Console.WriteLine();

            Console.WriteLine("******3. Locator******");
            Locator locator = new Locator();
            locator.LocateByValue();
            Console.WriteLine();

            Console.WriteLine("******3.a Locator through function******");
            locator.LocateByValue("L 3");
            Console.WriteLine();

            Console.WriteLine("******3.b Locator through file input******");
            locator.LocateByFile();
            Console.WriteLine();

            Console.WriteLine("******4. Pattern Program******");
            Patterns starPattern = new Patterns();
            starPattern.StarPattern();
            Console.WriteLine();

            Console.WriteLine("******5. Find Max Number in an array******");
            MaxNumber maxNumber = new MaxNumber();
            maxNumber.FindMaxNumber();


        }

        static void UniversityGradingSystem()
        {
            //TGet the marks and convert it into integer

            Console.WriteLine("Enter your marks between 0 t0 100: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            //Grading the students according to the marks

            if (marks <= 100 && marks >= 85)
            {
                Console.WriteLine("Your grade is A+");
            }
            else if (marks < 85 && marks >= 75)
            {
                Console.WriteLine("Your grade is A");
            }
            else if (marks < 75 && marks >= 70)
            {
                Console.WriteLine("Your grade is A-");
            }
            else if (marks < 70 && marks >= 65)
            {
                Console.WriteLine("Your grade is B+");
            }
            else if (marks < 65 && marks >= 60)
            {
                Console.WriteLine("Your grade is B");
            }
            else if (marks < 60 && marks >= 55)
            {
                Console.WriteLine("Your grade is B-");
            }
            else if (marks < 55 && marks >= 50)
            {
                Console.WriteLine("Your grade is C+");
            }
            else if (marks < 50 && marks >= 45)
            {
                Console.WriteLine("Your grade is C");
            }
            else if (marks < 45 && marks >= 40)
            {
                Console.WriteLine("Your grade is C-");
            }
            else if (marks < 40 && marks >= 35)
            {
                Console.WriteLine("Your grade is D+");
            }
            else if (marks < 35 && marks >= 30)
            {
                Console.WriteLine("Your grade is D");
            }
            else if (marks < 30 && marks >= 0)
            {
                Console.WriteLine("Your grade is D");
            }
            else
                Console.WriteLine("Invalid Input");
        }

        // BMI Calculator
        static void BMICalculator()
        {
            Console.WriteLine("Please enter your age in Years (20 to 120 years only)");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your Gender (M or F)");
            string gender = Console.ReadLine();

            Console.WriteLine("Please enter your height in centimeters (cm)");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your weight in kilograms (kg)");
            int weight = Convert.ToInt32(Console.ReadLine());

            //Calculate the BMI value
            double heightInMeters = height / 100; 
            double bmi = weight / Math.Pow(heightInMeters, 2); 
            Console.WriteLine($"Your BMI value is {bmi:F2} ");


            if (age >= 2 && age < 20)
            {
                if (gender.ToUpper() == "M")
                {
                   /* Console.WriteLine("https://www.researchgate.net/figure/BMI-Body-Mass-Index-cut-points-by-age-for-teenage-boys-and-girls_tbl3_308749102");
                    Console.WriteLine("You are male");*/
                }
                else
                {

                }

            }

            else if (age >= 20 && age < 120)
            {
                if (bmi < 18.5)
                {
                    Console.WriteLine("You are Underweight");
                }

                else if (bmi >= 18.5 && bmi < 25)
                {
                    Console.WriteLine("You are healthy");
                }

                else if (bmi >= 25 && bmi < 30)
                {
                    Console.WriteLine("You are overwight");
                }
                else
                {
                    Console.WriteLine("You are obese");
                }

            }

            else
            {
                Console.WriteLine("The age is not in the range");
            }

        }





    }
}
