using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Arrays
{
    class RemoveDuplicatesFromPrimeNumberArray
    {
        /* public static void removeDuplicates(int[] array)
         {
             int n = array.Length;
             long product = array[0];
             for(int i=1; i<n; i++)
             {
                 if (product % array[i] == 0)
                 {
                     array[i] = -array[i];
                 }
                 else
                     product = product * array[i];
             }
             for (int i = 0; i < n; i++)
             {
                 if (array[i] >= 0)
                     Console.Write(array[i] + " ");
             }
         }
         */

        public static void removeDuplicatesOnlogn(int[] array)
        {
            Array.Sort(array);
            int n = array.Length;
            int i = 0, j = 0, k = 0;
            for (i = 0; i < n;)
            {
                while (j < n && array[i] == array[j])
                {
                    j++;
                }
                int t = array[i];
                array[i] = array[k];
                array[k] = t;
                i = j;
                k++;
            }
            for (int p = 0; p < k; p++)
            {
                Console.Write(array[p] + " ");
            }
        }

        public static void testRemoveDuplicates()
        {
            int[] input = { 3, 5, 7, 2, 2, 5, 7, 7 };
            removeDuplicatesOnlogn(input);
        }
    }
}
