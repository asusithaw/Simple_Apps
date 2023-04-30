using Aspose.Cells;
using System;
using System.IO;

namespace Assignment_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("******1. University Grading System******");
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
            Console.WriteLine();*/

            Console.WriteLine("******4. Pattern Program******");
            Patterns starPattern = new Patterns();
            /*starPattern.StarPatternBackSlash();
            Console.WriteLine();*/
            //starPattern.StarPatternForwardSlash();
            //starPattern.StarPatternX();
            //starPattern.StarPatternXBy2DArray();
            starPattern.MergeAllPatterns();
            //starPattern.StarPatternTriangle();

            /*Console.WriteLine("******5. Find Max Number in an array******");
            MaxNumber maxNumber = new MaxNumber();
            maxNumber.FindMaxNumber();
            maxNumber.FindMaxNumberByOneLoop();*/

            /*Console.WriteLine("******6. Lottery Draw******");
            LotteryTicket lotteryTicket = new LotteryTicket();
            lotteryTicket.AmountOfLotteryTicketWinning();*/

            /*Console.WriteLine("******6 a. Lottery Draw******");
            LotteryTicketShanidaWasanawa lotteryTicketShanidaWasanawa = new LotteryTicketShanidaWasanawa();
            lotteryTicketShanidaWasanawa.AmountOfLotteryTicketWinning();*/

            /*Console.WriteLine("When it traverse through 10K elements array");
            int calculatedTimeForOneLoop10K = maxNumber.CalculateTimeForOneForLoop(10000);//0
            int calculatedTimeForTwoLoop10K = maxNumber.CalculateTimeForTwoForLoops(10000);//307

            Console.WriteLine("When it traverse through 20K elements array");
            int calculatedTimeForOneLoop20K = maxNumber.CalculateTimeForOneForLoop(20000);//0
            int calculatedTimeForTwoLoop20K = maxNumber.CalculateTimeForTwoForLoops(20000);//1344

            Console.WriteLine("When it traverse through 30K elements array");
            int calculatedTimeForOneLoop30K = maxNumber.CalculateTimeForOneForLoop(30000);//0
            int calculatedTimeForTwoLoop30K = maxNumber.CalculateTimeForTwoForLoops(30000);//2719

            Console.WriteLine("When it traverse through 40K elements array");
            int calculatedTimeForOneLoop40K = maxNumber.CalculateTimeForOneForLoop(40000);//0
            int calculatedTimeForTwoLoop40K = maxNumber.CalculateTimeForTwoForLoops(40000);//5097

            Console.WriteLine("When it traverse through 50K elements array");
            int calculatedTimeForOneLoop50K = maxNumber.CalculateTimeForOneForLoop(50000);//0
            int calculatedTimeForTwoLoop50K = maxNumber.CalculateTimeForTwoForLoops(50000);//8239

            // Instantiate a Workbook object
            Workbook workbook = new Workbook();

            // Obtain the reference of the first worksheet
            Worksheet worksheet = workbook.Worksheets[0];

            // Add sample values to cells
            worksheet.Cells["A2"].PutValue("10K Random Numbers");
            worksheet.Cells["A3"].PutValue("20K Random Numbers");
            worksheet.Cells["A4"].PutValue("30K Random Numbers");
            worksheet.Cells["A5"].PutValue("40K Random Numbers");
            worksheet.Cells["A6"].PutValue("50K Random Numbers");

            worksheet.Cells["B1"].PutValue("Single For-Loop Version");
            worksheet.Cells["B2"].PutValue(calculatedTimeForOneLoop10K);
            worksheet.Cells["B3"].PutValue(calculatedTimeForOneLoop20K);
            worksheet.Cells["B4"].PutValue(calculatedTimeForOneLoop30K);
            worksheet.Cells["B5"].PutValue(calculatedTimeForOneLoop40K);
            worksheet.Cells["B6"].PutValue(calculatedTimeForOneLoop50K);

            worksheet.Cells["C1"].PutValue("Dual For-Loop Version");
            worksheet.Cells["C2"].PutValue(calculatedTimeForTwoLoop10K);
            worksheet.Cells["C3"].PutValue(calculatedTimeForTwoLoop20K);
            worksheet.Cells["C4"].PutValue(calculatedTimeForTwoLoop30K);
            worksheet.Cells["C5"].PutValue(calculatedTimeForTwoLoop40K);
            worksheet.Cells["C6"].PutValue(calculatedTimeForTwoLoop50K);

            // Add a chart to the worksheet
            int chartIndex = worksheet.Charts.Add(Aspose.Cells.Charts.ChartType.Column, 7, 0, 30, 10);

            // Access the instance of the newly added chart
            Aspose.Cells.Charts.Chart chart = worksheet.Charts[chartIndex];

            // Set chart data source as the range  "A1:C6"
            chart.SetChartDataRange("A1:C6", true);

            // Save the Excel file
            if (File.Exists(@"D:\ASP.net\Assignment_01\Column-Chart.xls"))
            {
                File.Delete(@"D:\ASP.net\Assignment_01\Column-Chart.xls");
            }else
            workbook.Save(@"D:\ASP.net\Assignment_01\Column-Chart.xls");*/


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
