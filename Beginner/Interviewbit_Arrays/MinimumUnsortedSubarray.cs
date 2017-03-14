using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Interviewbit_Arrays
{
    //http://www.geeksforgeeks.org/minimum-length-unsorted-subarray-sorting-which-makes-the-complete-array-sorted/
    class MinimumUnsortedSubarray
    {
        public static void unsortedArray(int[] array)
        {
            int n = array.Length;
            int s = 0, e = n - 1, max = 0, min = 0;
            for (s = 0; s < n - 1; s++)
            {
                if (array[s] > array[s + 1])
                    break;   
            }
            if (s == n - 1)
                Console.Write("array is sorted");
            for (e = n - 1; e > 0; e--)
            {
                if (array[e] < array[e - 1])
                    break;
            }
            max = array[s];
            min = array[e];
            for (int i = s + 1; i <= e; i++)
            {
                if (array[i] > max)
                    max = array[i];
                if (array[i] < min)
                    min = array[i];
            }
            for (int i = 0; i < s; i++)
            {
                if (array[i] > min)
                {
                    s = i;
                    break;
                }
            }
            for (int i = e + 1; i < n; i++)
            {
                if (array[i] < max)
                {
                    e = i;
                    break;
                }
            }
            Console.WriteLine("unsorted subarray starts from index " + s + " and ends on index " + e);
        }
        public static void testUnsortedArray()
        {
            int[] input = {10,12,20,30,25,40,32,31,35,50,60 };
            unsortedArray(input);
        }
    }
}
