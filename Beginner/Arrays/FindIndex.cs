using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Arrays
{
    public class Num : IComparable
    {
        public int element;
        public int index;

        public int CompareTo(object obj)
        {

            var incomingObject = obj as Num;
            Console.WriteLine("Comparing using comparable: " + this.element + " : " + incomingObject.element);
            if (this.element == incomingObject.element)
                return 0;
            else if (this.element > incomingObject.element)
                return 1;
            else
                return -1;
        }
    };

    public class MyComparer : IComparer<Num>
    {
        public int Compare(Num x, Num y)
        {
            Console.WriteLine("Comparing using comparer: " + x.element + " : " + y.element);
            if (x.element == y.element)
                return 0;
            else if (x.element > y.element)
                return 1;
            else
                return -1;
            // Shortcut way of writing the if-else above
            //return x.element - y.element;
        }
    }

    public class FindIndex
    {
        public static int FindingIndex(int[] arr, int x)
        {
            
            Num[] newarr = new Num[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                Num temp = new Num();
                temp.element = arr[i];
                temp.index = i;
                newarr[i] = temp;
            }

            //Array.Sort(newarr, new MyComparer());
            Array.Sort(newarr);

            Console.WriteLine("Sorted Array");
            for(int i = 0; i < newarr.Length; i++)
            {
                Console.WriteLine(newarr[i].element + ":" + newarr[i].index);
            }

            int high = newarr.Length - 1;
            int low = 0;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (newarr[mid].element == x)
                    return newarr[mid].index;
                else if (newarr[mid].element < x)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return -1;
        }

        public static void TestFindingIndex()
        {
            int[] array = {3, 4, 2, 10, 8, 9 };
            Console.WriteLine("Result is : " + FindingIndex(array, 9));
        }
        
    }

}
