using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Arrays
{
    class ArrayIntersection
    {
        public static int[] Intersection(int[] m, int[] n)
        {
            int i = 0, j = 0;
            List<int> result = new List<int>();
            while (i < m.Length && j < n.Length)
            {
                if (m[i] == n[j])
                {
                    result.Add(m[i]);
                    i++;
                    j++;
                }
                else if (m[i] < n[j])
                    i++;
                else
                    j++;
            }
            return result.ToArray();
        }
        public static void TestIntersection()
        {
            Console.WriteLine("enter the size of 1st array");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            for (int i = 0; i < size; i++)
                a[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the size of 2nd array");
            int size1 = int.Parse(Console.ReadLine());
            int[] b = new int[size1];
            for (int i = 0; i < size1; i++)
                b[i] = int.Parse(Console.ReadLine());

            int[] result = Intersection(a, b);
            for (int i = 0; i < result.Length; i++)
                Console.WriteLine(result[i]);
        }
        public static bool BinarySearch(int[] arr, int x)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low < high)
            {
                int mid = (low + high) / 2;
                if (arr[mid] == x)
                    return true;
                else if (x < arr[mid])
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            return false;
        }
        public static int[] IntersectionUsingBinarySearch(int[] m, int[] n)
        {
            List<int> result = new List<int>();

            if (m.Length > n.Length)
            {
                for (int i = 0; i < n.Length; i++)
                {
                    BinarySearch(m, n[i]);
                    if (BinarySearch(m, n[i]) == true)
                        result.Add(n[i]);
                }
            }
            else
            {
                for (int i = 0; i < m.Length; i++)
                {
                    BinarySearch(n, m[i]);
                    if (BinarySearch(n, m[i]) == true)
                        result.Add(m[i]);
                }
            }
            return result.ToArray();
        }

        public static void TestIntersectionUsingBinarySearch()
        {
            Console.WriteLine("enter the size of 1st array");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            for (int i = 0; i < size; i++)
                a[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the size of 2nd array");
            int size1 = int.Parse(Console.ReadLine());
            int[] b = new int[size1];
            for (int i = 0; i < size1; i++)
                b[i] = int.Parse(Console.ReadLine());

            int[] result = IntersectionUsingBinarySearch(a, b);
            for (int i = 0; i < result.Length; i++)
                Console.WriteLine(result[i]);
        }

    }
}