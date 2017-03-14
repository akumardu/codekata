using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Interviewbit_Arrays
{
    class MaxSumContigousSubarray
    {
        public static void maxSum(int[] arr)
        {
            int max_so_far = int.MinValue;
            int max_ending_here = 0;
            int s = 0, start = 0, end = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                max_ending_here = max_ending_here + arr[i];

                if (max_so_far < max_ending_here)
                {
                    max_so_far = max_ending_here;
                    start = s;
                    end = i;
                }
                if (max_ending_here < 0)
                {
                    max_ending_here = 0;
                    s = i + 1;
                }
            }
            Console.WriteLine(max_so_far);
            Console.WriteLine(start);
            Console.WriteLine(end);
        }
        public static void testMaxSum()
        {
            int[] arr = { -2, -3, 4, -1, 2, 1, -5, -3 };
            maxSum(arr);
        }
    }
}
