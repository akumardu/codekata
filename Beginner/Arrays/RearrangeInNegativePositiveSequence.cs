using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Arrays
{
    class RearrangeInNegativePositiveSequence
    {
        public static void sequence(int[] array)
        {
            int n = array.Length;
            int i = 0, j = n - 1;
            while (i < j)
            {
                while (i!=j && array[i] > 0)
                    i++;
                while (i!=j && array[j] < 0)
                    j--;
                if (i < j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            if (i == 0 || i == n)
                return;
         
            int k = 1;
            while ( i<n && k<n)
            {
                int temp = array[k];
                array[k] = array[i];
                array[i] = temp;
                k = k + 2;
                i = i + 1;
            }
        }
        public static void testSequence()
        {
            int[] array = { 2, 3, -4, -1, 6, -9, 1, 5, 7 };
            sequence(array);
            for (int i = 0; i <array.Length; i++)
            {
                Console.Write(array[i] + "  ");
            }
        }
    }
}
 