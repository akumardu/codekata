using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Arrays
{
    class MostOftenElement
    {
        public static int SortedMostOftenElement(int[] arr)
        {
            int count = 0, maxCount = 0, maxelement = arr[0];
            int j = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                while (j < arr.Length && arr[i] == arr[j])
                {
                    j++;
                }
                count = j - i;
                if (count > maxCount)
                {
                    maxCount = count;
                    maxelement = arr[i];
                }
            }
            return maxelement;
        }
        public static void TestMostOftenElement()
        {
            int[] arr = Utility.ReadArrayFromConsole();
            Console.WriteLine("Most often array: " + SortedMostOftenElement(arr));
        }

        public static int UnsortedMostOften(int[] arr)
        {
            int maxcount = 0;
            int maxelement = arr[0];
           // int count = 0;

            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!dict.ContainsKey(arr[i]))
                {
                    dict.Add(arr[i], 1);
                }
                else
                {
                    dict[arr[i]]++;
                    // In case you want to do eager finding
                    //count = dict[arr[i]];
                    //if (count > maxcount)
                    //{
                    //    maxcount = count;
                    //    maxelement = arr[i];
                    //}
                }
            }

            // iterate through the dictionary to find the largest occurring element
            foreach(var kvp in dict)
            {
                if(maxcount < kvp.Value)
                {
                    maxcount = kvp.Value;
                    maxelement = kvp.Key;
                }
            }

            return maxelement;
        }
    }
}
    
