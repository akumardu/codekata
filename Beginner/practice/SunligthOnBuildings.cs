using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    class SunligthOnBuildings
    {
        public static int sunlight(int[] arr)
        {
            int count = 1;
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    count++;
                }
            }
            return count;
        }
        public static void testSunlight()
        {
            int[] arr = { 3, 4, 1, 0, 6 ,2 ,3 };
            int result = sunlight(arr);
            Console.WriteLine(result);
        }
    }
}
