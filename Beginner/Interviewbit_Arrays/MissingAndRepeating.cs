using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Interviewbit_Arrays
{
    class MissingAndRepeating
    {
        public static void missingAndrepeating(int[] arr)
        { 
            int n = arr.Length;
            for(int i=0; i<n; i++)
            {
                if (arr[Math.Abs(arr[i]) - 1] > 0)
                {
                    arr[Math.Abs(arr[i]) -1] = -arr[Math.Abs(arr[i]) - 1];
                }
                else
                {
                    Console.WriteLine("repeating number is " + Math.Abs(arr[i]));
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                    Console.WriteLine("missing number is " + (i + 1));
            }
        }
        public static void testMissingAndRepeating()
        {
            int[] arr = { 7, 3, 4, 5, 5, 6, 2 };
            int[] arr2 = {3, 1, 2, 5, 3 };
            missingAndrepeating(arr);
            missingAndrepeating(arr2);

        }

    }
}
