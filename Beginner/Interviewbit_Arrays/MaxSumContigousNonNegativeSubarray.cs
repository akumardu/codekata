using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Interviewbit_Arrays
{
    class MaxSumContigousNonNegativeSubarray
    {
        public static void nonNegativeSubarray(int[] arr)
        {
            int max_so_far = int.MinValue;
            int max_ending_here = 0;
            int n = arr.Length;
            int start = 0, end = 0, s = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                {
                    max_ending_here = max_ending_here + arr[i];
                }
                if (max_so_far < max_ending_here)
                {
                    max_so_far = max_ending_here;
                    start = s;
                    end = i;
                }
                if (arr[i] < 0)
                    max_ending_here = 0;
            }
            Console.WriteLine(start);
            Console.WriteLine(end);
            Console.WriteLine(max_so_far);
        }
        public static void testNonNegativeSubarray()
        {
            int[] arr = { 1, 2, 5, -7, 2, 3 };
            nonNegativeSubarray(arr);
        }
    }
}
