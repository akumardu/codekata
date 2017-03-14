using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Interviewbit_Arrays
{
    class MaxSumContigousBinarySubarray
    {
        public static void binarySubarray(int[] arr)
        {
            int n = arr.Length;
            int start = 0, end = 0, s = 0;
            int max_sofar = int.MinValue;
            int max_ending_here = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == 0)
                    arr[i] = 1;
                else if (arr[i] == 1)
                    arr[i] = -1;
            }

            for (int i = 0; i < n; i++)
            {
                max_ending_here = max_ending_here + arr[i];
                if (max_ending_here > max_sofar)
                {
                    max_sofar = max_ending_here;
                    start = s;
                    end = i;
                }
                if (max_ending_here < 0)
                {
                    max_ending_here = 0;
                    s = i + 1;
                }
            }
            Console.WriteLine("start index is " + start);
            Console.WriteLine("endindex is " + end);
            Console.WriteLine("max sum is " + max_sofar);
        }
        public static void testBinaryArray()
        {
            int[] input = {0,1,0 };
            binarySubarray(input);
        }
    }
}
