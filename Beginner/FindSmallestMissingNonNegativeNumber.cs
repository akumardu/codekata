using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    class FindSmallestMissingNonNegativeNumber
    {
        public static int segregate(int[] arr)
        {
            int size = arr.Length;
            int i = 0, j = size - 1;
            while (i < j)
            {
                while (i < size && arr[i] >= 0)
                    i++;
                while (j >= 0 && arr[j] < 0)
                    j--;
                if (i < j)
                {
                    int temp;
                    temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
            }
            int k = 0;
            while (k< size && arr[k] >= 0)
                k++;
            return k;
        }

        public static int FindMissingPositive(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                int index = Math.Abs(arr[i]);
                if (index < size && arr[index] > 0)
                    arr[index] = -arr[index];
            }
            for (int i = 0; i < size; i++)
            {
                if (arr[i] > 0)
                    return i;
            }
            return size;
        }
        public static int findMissing(int [] arr)
        {
            int shift = segregate(arr);
            return FindMissingPositive(arr, shift); 
         }
        public static void testMissing()
        {
            int[] arr = { 1000,2000,3000,1500,6000};
            Console.WriteLine("array index is " + segregate(arr));

            Console.WriteLine("missing positive number is " + findMissing(arr));
        }

    }
}
