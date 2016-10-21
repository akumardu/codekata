using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Codewar
{
    class DeleteAfterNElements
    {
        public static int[] DeleteNth(int[] arr, int x)
        {
            int count = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!dict.ContainsKey(arr[i]))
                {
                    dict.Add(arr[i], 1);
                    list.Add(arr[i]);
                }
                else
                {
                    count = dict[arr[i]];
                    count++;
                    if (count <= x)
                    {
                        dict[arr[i]] = count;
                        list.Add(arr[i]);
                    }
                }

            }
            return list.ToArray();
        }
        public static void testDeleteNth()
        {
            Console.WriteLine("enter the value of x");     
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the size of the array");
            int size=int.Parse( Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
                arr[i] = int.Parse(Console.ReadLine());
            int[] result = DeleteAfterNElements.DeleteNth(arr, x);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }


    }

}