using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Interviewbit_Arrays
{
    //http://www.geeksforgeeks.org/given-an-array-arr-find-the-maximum-j-i-such-that-arrj-arri/
    //https://www.interviewbit.com/problems/max-distance/
    
    class MaximumIndexDifference
    {
        public static int maxDifference(int[] arr)
        {
            int max_diff = -1;
            int[] left_min = new int[arr.Length];
            int[] right_max = new int[arr.Length];

            left_min[0] = arr[0];
            for(int i=1; i<arr.Length; i++)
            {
                left_min[i] = Math.Min(arr[i], left_min[i - 1]);
            }

            right_max[arr.Length - 1] = arr[arr.Length - 1];
            for (int j = arr.Length - 2; j >= 0; j--)
            {
                right_max[j] = Math.Max(arr[j], right_max[j + 1]);
            }
            for (int i = 0, j = 0; i < arr.Length && j < arr.Length;)
            {
                if (left_min[i] < right_max[j])
                {
                    max_diff = Math.Max(max_diff, j - i);
                    j = j + 1;
                }
                else
                    i = i + 1;
            }
            return max_diff;
        }
        public static void testMaxDifference()
        {
            int[] arr = { 9, 2, 3, 4, 5, 6, 7, 8, 18, 0 };
            int result = maxDifference(arr);

            int[] arr2 = { 34, 8, 10, 3, 2, 80, 30, 33, 1 };
            int result2 = maxDifference(arr2);

            int[] arr3 = { 1, 2, 3, 4, 5, 6 };
            int result3 = maxDifference(arr3);

            int[] arr4 = {6,5,4,3,2,1 };
            int result4 = maxDifference(arr4);

            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
        }
    }
}
