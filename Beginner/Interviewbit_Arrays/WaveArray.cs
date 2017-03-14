using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Interviewbit_Arrays
{
    //http://www.geeksforgeeks.org/sort-array-wave-form-2/
    class WaveArray
    {
        public static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static void wave(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i += 2)// we are traversing only even elements
            {
                if (i > 0 && array[i] < array[i - 1])
                    swap(ref array[i], ref array[i - 1]);

                if (i < n - 1 && array[i] < array[i + 1])
                    swap(ref array[i], ref array[i + 1]);
            }
        }
        public static void testWave()
        {

            int[] input = { 10, 90, 49, 21, 5, 25 };
            wave(input);
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + " ");
            }
        }
    }
}
