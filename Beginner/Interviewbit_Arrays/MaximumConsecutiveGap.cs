using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Interviewbit_Arrays
{
    class MaximumConsecutiveGap
    {
        public static int consecutiveGap(int[] array)
        {
            int n = array.Length;
            int max_difference = 0;
                if (n < 2)
                return 0;
            Array.Sort(array);
            for (int i = 0; i < n - 1; i++)
            {
                int temp_difference = array[i+1]-array[i];
                if (temp_difference > max_difference)
                    max_difference = temp_difference;
            }
            return max_difference;
        }
        public static void testConsecutiveGap()
        {
            int[] input = {2,3,10,6,4,8,1};
            int output = consecutiveGap(input);
            Console.Write(output);
        }

    }
}
