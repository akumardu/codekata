using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Arrays
{
    class RemoveDuplicatesFromArray
    {
        public static int[] RemoveDuplicates(int []arr)
        {
            int i = 0, j = 0, k = 0;
            for (i = 0; i < arr.Length; )
            {
                while (j < arr.Length && arr[i] == arr[j])
                {
                    j++;
                }
                
                int t = arr[i];
                arr[i] = arr[k];
                arr[k] = t;
                i = j;
                k++;
            }

            while(k < arr.Length)
            {
                arr[k] = 0;
                k++;
            }
            return arr;
        }
        public static void TestRemoveDuplicates()
        {
            Console.WriteLine("enter the size of array");
            int size= int.Parse(Console.ReadLine());
            Console.WriteLine("enter array");
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
                arr[i] = int.Parse(Console.ReadLine());
            RemoveDuplicates(arr);
            Console.WriteLine("the resultant arry is");
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }
    }
}
