using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Interviewbit_Arrays
{
   // https://www.interviewbit.com/problems/min-steps-in-infinite-grid/
    struct Point
    {
       public int x;
       public int y;
    };
    class MaxStepsInMatrix
    {
        public static int steps(List<Point> list)
        {
            int result=0;
            for (int i = 1; i < list.Count; i++)
            {
                result = result + Math.Max(Math.Abs(list[i].x - list[i-1].x), Math.Abs(list[i].y - list[i - 1].y));
            }
            return result;
        }
        public static void testSteps()
        {
            var list = new List<Point>();
            list.Add(new Point() { x = 0, y = 0 });
            list.Add(new Point() { x = 1, y = 1 });
            list.Add(new Point() { x = 1, y = 2 });
            int result = steps(list);
            Console.WriteLine(result + " ");
        }
    }
}
