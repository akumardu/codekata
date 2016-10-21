using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Arrays
{
    class ReverseArray
    {
        public static int[] ReverseInPlace(int []arr)
        {
            for (int i = 0, j = arr.Length - 1; i < j; i++, j--)
           {
                int t = arr[i];
                arr[i] = arr[j];
                arr[j] = t;
           }
            return arr;
        }
        public static void TestReverseInPlace()
        {
            Console.WriteLine("enter the size of the array");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
                arr[i] = int.Parse(Console.ReadLine());
            ReverseInPlace(arr);
            for (int i = 0; i < size; i++)
                Console.WriteLine(arr[i]);
        }

        public static int[] ReverseInAnotherArray(int[] input, int [] output)
        {
            for(int i=0; i<input.Length;i++)
            {
                output[input.Length - i- 1] = input[i];
            }
            return output;
        }
        public static void TestReverseInAnotherArray()
        {
            Console.WriteLine("enter the size");
            int size=int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
                arr[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the size for second array");
            int size1= int.Parse(Console.ReadLine());
            int[] result = new int[size1];
            ReverseInAnotherArray(arr, result);
            for (int i = 0; i < size; i++)
                Console.WriteLine(result[i]);
        }
    }
}
