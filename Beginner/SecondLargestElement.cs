using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    class SecondLargestElement
    {
       /* public static int[] sort(int [] array)
        {
            int size = array.Length;
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
        */


        public static int secondLargest(int[] arr)
        {
            int largest = int.MinValue;
            int secondLargest = int.MinValue;
            int size = arr.Length;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] > largest)
                {
                    secondLargest = largest;
                    largest = arr[i];
                }
                else if (arr[i] > secondLargest)
                    secondLargest = arr[i];
            }
            return secondLargest;
        }
        public static void testArray()
        {
            int[] array = { 89, 24, 75, 11 ,23 };
            //sort(array);
            //for (int i = 0; i < array.Length; i++)
            // Console.WriteLine(array[i]);
            //Console.WriteLine("the second largest element is  "+ array[array.Length-2]);
            int secondL = secondLargest(array);
            Console.WriteLine(secondL);
        }

    }
}
