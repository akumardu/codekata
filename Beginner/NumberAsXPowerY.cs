using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    class NumberAsXPowerY
    {
        public static bool IsPower(int n)
        {
            if (n == 1)
                return true;
            for (int x = 2; x <= Math.Sqrt(n); x++)
            {
                int y = 2;
                double p = Math.Pow(x, y);
                while (p <= n && p > 0)
                {
                    if (p == n)
                        return true;
                    y++;
                    p = Math.Pow(x, y);
                }
            }
            return false;
        }
        public static void testIsPower()
        {
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            bool result = IsPower(n);
            Console.WriteLine(result);
        } 
    }
} 
