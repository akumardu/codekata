using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    //http://www.practice.geeksforgeeks.org/problem-page.php?pid=582
    class AverageAtEveryPoint
    {
        public static int[] Average(int[] array)
        {
            int avgAtIndexI = 0, sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                avgAtIndexI = (sum + array[i]) / (i + 1);
                sum = sum + array[i];
                array[i] = avgAtIndexI;
            }
            return array;
        }
        public static void testAverage()
        {
            int[] input = { 10, 20, 30, 40, 50 };
            Average(input);
            for (int i = 0; i < input.Length; i++)
                Console.Write(input[i] + " ");
        }
    }
}
