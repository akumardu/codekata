using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Interviewbit_Arrays
{
    //https://www.interviewbit.com/problems/add-one-to-number/
    class Add1ToANumberInAnArray
    {
        public static void add1ToANumber(int [] arr)
        {
            List<int> list = new List<int>();
            int carry = 1;
            for (int i = arr.Length- 1; i >= 0; i--)
            {
                int sum;
                sum = arr[i] + carry;
                carry = sum / 10;
                list.Add(sum % 10);
            }
            list.Add(carry);

            int k = list.Count - 1;
            while(k>=0 && list[k] == 0)
            {
                k--;  
            }
            for (int i = k; i >= 0; i--)
            {
                Console.Write(list[i] + " ");
            }
        }
        public static void testAdd1ToANumber()
        {
            int[] arr = { 0,0,0,0,0 };
            int[] arr1 = { 0, 1, 2, 3 };
            int[] arr2 = { 0, 9, 9, 9 };
            int[] arr3 = { 9, 9, 9, 9 };

            add1ToANumber(arr);
            Console.WriteLine(" ");
            add1ToANumber(arr1);
            Console.WriteLine(" ");
            add1ToANumber(arr2);
            Console.WriteLine(" ");
            add1ToANumber(arr3);
        }
    }
}
