using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Interviewbit_Arrays
{
    //http://www.geeksforgeeks.org/find-the-two-repeating-elements-in-a-given-array/
    class FindDuplicateInAnArray
    {
        //case- 1: if numbers in the array are from zero to n & there are only positive numbers in the array.
       public static List<int> duplicate1(int[] array)
        {
            List<int> list = new List<int>();
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                while(array[array[i]]!=array[i])
                {
                    int temp = array[array[i]];
                    array[array[i]] = array[i];
                    array[i]= temp;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (array[i] != i)
                list.Add(array[i]);
            }
            return list;
        }
        
        //case-2: if the numbers in an array are between 1 to n. and only positive numbers.

       public static List<int> duplicate2(int[] array)
        {
            int n = array.Length;
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (array[Math.Abs(array[i]) - 1] > 0)
                {
                    array[Math.Abs(array[i]) - 1] = -array[Math.Abs(array[i]) - 1];
                }
            }
                for(int i=0; i<n; i++)
                {
                     if(array[i]>0)
                    list.Add(array[i]);
                }
            
            return list;
        }

     

        public static void testDuplicate()
        {
            int[] input1 = {1,2,3,1,3,6,0}; // if we remove zero from the array. duplicate1 will give indexoutofbound exception in line18.
            int[] input2 = {3,4,1,4,1};
           List<int> output1=duplicate1(input1);
           List<int> output2 = duplicate2(input2);
           for (int i = 0; i < output1.Count; i++)
            {
                Console.WriteLine(output1[i]);
            }
            Console.WriteLine("------------------");
            for (int i = 0; i < output2.Count; i++)
            {
                Console.WriteLine(output2[i]);
            }
        }
    }
}
