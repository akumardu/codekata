using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    class ImmediateSmallerElement
    {
        public static List< int > immediateSmaller(int[] array)
        {
            List<int> list = new List<int>();
            int size = array.Length;
            for (int i = 0, j=1; i < size-1 || j<size; i++, j++)
            {
                if (array[i] > array[j])
                    list.Add(array[j]);
                else
                    list.Add(-1);
            }
            list.Add(-1);
            return list;
        }
        public static void testImmediateSmaller()
        {
            int[] array = { 4, 2, 1, 5, 3 };
            List<int> list = new List<int>();
            list = immediateSmaller(array);
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);
        }

    }
}
