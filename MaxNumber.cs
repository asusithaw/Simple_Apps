using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Assignment_01
{
    class MaxNumber
    {
        int[] array = { 10, 2, 13, 4, 7, 16, 8, 12 };

        //Find the max number by using two for-loops (Sorting the array is also included)
        public void FindMaxNumber()
        {


            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }

                }

            }
            Console.WriteLine($"The max value is {array[0]}");
        }




        //Find the max number by using one for-loop
        public void FindMaxNumberByOneLoop()
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[0] < array[i])
                {
                    array[0] = array[0] + array[i];
                    array[i] = array[0] - array[i];
                    array[0] = array[0] - array[i];
                }

            }
            Console.WriteLine($"The max value is {array[0]}");
        }





        public int CalculateTimeForOneForLoop(int numberOfElements)
        {
            //To generate random numbers, created a object of Random class.
            Random randomNumber = new Random();

            //Declare new array of 10K elements, and assign values on it 
            int[] array = new int[numberOfElements];
            for (int i = 0; i < numberOfElements; i++)
            {
                array[i] = randomNumber.Next();
            }

            //Create new stop watch
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            for (int i = 1; i < array.Length; i++)
            {
                if (array[0] < array[i])
                {
                    array[0] = array[0] + array[i];
                    array[i] = array[0] - array[i];
                    array[0] = array[0] - array[i];
                }

            }

            stopwatch.Stop();

            int elapsedTime = (int)stopwatch.ElapsedMilliseconds;

            Console.WriteLine($"The max value is {array[0]}");
            Console.WriteLine($"Time elapsed: {elapsedTime}");

            return elapsedTime;

        }




        public int CalculateTimeForTwoForLoops(int numberOfElements)
        {
            //To generate random numbers, created a object of Random class.
            Random randomNumber = new Random();

            //Declare new array of 10K elements, and assign values on it 
            int[] array = new int[numberOfElements];
            for (int i = 0; i < numberOfElements; i++)
            {
                array[i] = randomNumber.Next();
            }

            //Create new stop watch
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }

                }

            }

            int elapsedTime = (int)stopwatch.ElapsedMilliseconds;

            Console.WriteLine($"The max value is {array[0]}");
            Console.WriteLine($"Time elapsed: {elapsedTime}");

            return elapsedTime;

        }


    }
}
