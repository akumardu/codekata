using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Interviewbit_Arrays
{
    class DuplicateOn
    {
        public static void duplicate(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[Math.Abs(arr[i])-1] > 0)
                {
                    arr[Math.Abs(arr[i]) - 1] = -arr[Math.Abs(arr[i]) - 1];
                }
            else
                    Console.WriteLine(Math.Abs(arr[i]));
            }
        }
        public static void testDuplicates()
        {
            int[] input = {3,4,1,4,1 };
            duplicate(input);
        }
    }
}
