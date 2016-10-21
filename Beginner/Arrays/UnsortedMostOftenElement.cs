using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Arrays
{
    class UnsortedMostOftenElement
    {
        public static int MostOftenElement(int[] arr)
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
            int []arr = Utility.ReadArrayFromConsole();
            Console.WriteLine("Most often array: " + MostOftenElement(arr));
        }


    }
}
