using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    class UglyNumbers
    {
        //http://www.practice.geeksforgeeks.org/problem-page.php?pid=553

        public static int findingUglyNumber(int n)
        {
            int [] ugly= new int[n] ;
            ugly[0] = 1;
            int i2=0, i3=0, i5 = 0;
            int next_ugly_number=1;
            int next_multiple_of_2 = ugly[i2] * 2;
            int next_multiple_of_3 = ugly[i3] * 3;
            int next_multiple_of_5 = ugly[i5] * 5;

            for (int i = 1; i < n; i++)
            {
                next_ugly_number = min(next_multiple_of_2, next_multiple_of_3, next_multiple_of_5);
                ugly[i] = next_ugly_number;

                if (next_ugly_number == next_multiple_of_2)
                {
                    i2 = i2 + 1;
                    next_multiple_of_2 = ugly[i2] * 2;
                }

                if (next_ugly_number == next_multiple_of_3)
                {
                    i3 = i3 + 1;
                    next_multiple_of_3 = ugly[i3] * 3;
                }
                if (next_ugly_number == next_multiple_of_5)
                {
                    i5 = i5 + 1;
                    next_multiple_of_5 = ugly[i5] * 5;
                }
            }
            return next_ugly_number; 
      }
        public static int min(int a, int b, int c)
        {
            if (a <= b && a <=  c  )
                return a;
            else if (b <=a && b <=c)
                return b;
            else return c;
         }
        public static void testFindingUglyNumber()
        {
            Console.WriteLine("enter the value of n");
            int n=int.Parse(Console.ReadLine());
            int result = findingUglyNumber(n);
            Console.WriteLine(n + "th ugly number is " + result);

        }
      }
 }

