using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    //http://www.geeksforgeeks.org/find-elements-array-least-two-greater-elements/
    class AtLeastTwoGreaterElements
    {
        public static List<int> greaterElements(int[] arr)
        {
            List<int> list = new List<int>();
            int greatestElement = int.MinValue;
            int secondGreatestElement = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > greatestElement)
                {
                    secondGreatestElement = greatestElement;
                    greatestElement = arr[i];
                }
                else if (arr[i] > secondGreatestElement)
                {
                    secondGreatestElement = arr[i];
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < secondGreatestElement)
                    list.Add(arr[i]);
            }
            return list;
        }
        public static void testGreaterElements()
        {
            int[] input = { 2, -6, 3, 5, 1 };
            List<int> list = new List<int>();
            list = greaterElements(input);
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);
        }

    }
}
