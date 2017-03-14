using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Interviewbit_Arrays
{
    //https://www.interviewbit.com/problems/maximum-absolute-difference/
    class MaximumAbsoluteDifference
    {
        public static int maxDifference(int[] arr) //Complexity of this method is O(n2).
        {
            int max_sum = 0;
            int temp_sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    temp_sum = sum(arr[i], arr[j], i, j);
                    if (max_sum < temp_sum)
                        max_sum = temp_sum;
                }
            }
            return max_sum;
        }
        public static int sum(int ai, int aj, int i, int j)
        {
            int absSum = (Math.Abs(ai - aj) + Math.Abs(i - j));
            return absSum;
        }
        public static int maxDifferenceModified(int[] arr) //Complexity of this method is O(n).
        {
            int n = arr.Length;
            int max1 = int.MinValue;
            int max2 = int.MinValue;
            int max3 = int.MinValue;
            int max4 = int.MinValue;
            int ans = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                max1 = Math.Max(max1, arr[i] + i);
                max2 = Math.Max(max2, arr[i] - i);
                max3 = Math.Max(max3, -arr[i] + i);
                max4 = Math.Max(max4, -arr[i] - i);
            }
            for (int i = 0; i < n; i++)
            {
                ans = Math.Max(ans, max1 - arr[i] - i);
                ans = Math.Max(ans, max2 - arr[i] + i);
                ans = Math.Max(ans, max3 + arr[i] - i);
                ans = Math.Max(ans, max4 + arr[i] + i);
            }
            return ans;
        }
        
        
        public static void testMaxDifference()
        {
            int[] arr = { 151, 0,75};
            int result = maxDifference(arr);
            Console.WriteLine(result);
            int result2 = maxDifferenceModified(arr);
            Console.WriteLine(result2);
        }
    }
}
