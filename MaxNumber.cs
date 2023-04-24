using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    class MaxNumber
    {
        public void FindMaxNumber()
        {
            int[] array = { 10, 2, 13, 4, 7, 16, 8, 12 };

            for (int i = 0; i < array.Length; i++)
            {
                for(int j=i+1; j< array.Length; j++)
                {
                    if(array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }

                }

            }
            Console.WriteLine($"The max value is {array[0]}");
        }
    }
}
