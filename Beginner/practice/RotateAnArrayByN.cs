using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    //Program to rotate an array by k.
    class RotateAnArrayByN
    {
        public static void reverse(int[] array , int start, int end)
        {
            for (int i = start, j = end; i < j; i++, j--)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
        public static void rotate(int[] array, int k)
        {
            if (k < 0)
                throw new ArgumentException("invalid argument k");
            else
                k = k % array.Length;
            if (k == 0)
                return;
            reverse(array, 0, array.Length - 1);
            reverse(array, 0, k - 1);
            reverse(array, k, array.Length - 1);
        }
        public static void testRotate()
        {
            int[] input = { 1, 2, 3, 4, 5, 6 };
            rotate(input, 2);
            //rotate(input, 0);
           // rotate(input, 7);
           // rotate(input, -1);


            for (int i = 0; i < input.Length; i++)
                Console.WriteLine(input[i]);
        }

    }

}
