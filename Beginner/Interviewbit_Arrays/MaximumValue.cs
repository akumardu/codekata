using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Interviewbit_Arrays
{
    //http://www.geeksforgeeks.org/find-maximum-value-of-absi-j-minarri-arrj-in-an-array-arr/
    class MaximumValue
    {
        public static int maxVal(int[] arr)
        {
            int max_product = int.MinValue;
            int temp_product = 0;
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                if (arr[left] < arr[right])
                {
                    temp_product = Math.Abs(left - right) * arr[left];
                    left++;
                }
                else
                {
                    temp_product = Math.Abs(left - right) * arr[right];
                    right--;
                }
                max_product = Math.Max(max_product, temp_product);
            }
            return max_product;
        }
        public static void testMAxVal()
        {
            int[] arr = { 8, 1, 9, 4 };
            int result = maxVal(arr);
            Console.WriteLine(result);
        }
    }
}
