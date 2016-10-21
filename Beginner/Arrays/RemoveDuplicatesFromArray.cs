﻿using System;
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
            int i = 0, j = 1, k = 1;
            for (i = 0; i < arr.Length; i++)
            {
                while (j < arr.Length && arr[i] == arr[j])
                {
                    j++;
                }
                if(j == arr.Length)
                {
                    break;
                }
                int t = arr[j];
                arr[j] = arr[k];
                arr[k] = t;
                i = j;
                j++;
                k++;
            }
            return arr;
        }
        public static void TestRemoveDuplicates()
        {
            Console.WriteLine("enter the size of array");
            int size= int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
                arr[i] = int.Parse(Console.ReadLine());
            RemoveDuplicates(arr);
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }
    }
}
