using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//http://www.geeksforgeeks.org/find-two-rectangles-overlap/
namespace Beginner
{
    struct Point
    {
       public int x, y;
    };
    class Overlappingrectangles
    {
        public static bool isOverlap(Point l1, Point r1, Point l2, Point r2)
        {
            if ((l1.x > r2.x) || (l2.x > r1.x)) // if rectangles are on their side. 
                return false;

            if ((l1.y < r2.y) || (l2.y < r1.y)) // if rectangle is above or below.
              return false;

            return true;
        }
        public static void testISOverlap()
        {
            Point l1 = new Point(){x = 0, y = 10 };
            Point r1 = new Point(){x = 10, y = 0 };
            Point l2 = new Point(){x = 5, y = 5 };
            Point r2 = new Point(){x = 15, y = 0 };
            if (isOverlap(l2, r1, l2, r2) == true)
                Console.WriteLine("overlap");
            else
                Console.WriteLine("dont overlap");
        }
    }
}
