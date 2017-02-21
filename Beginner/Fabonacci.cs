using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    class Fabonacci
    {
        public static bool isPerfectSquare(int x)
        {
            double s = Math.Sqrt(x);
            return (s * s == x);
        }
        public static void checkNISFabonacci(int n)
        {
            if ((isPerfectSquare(5 * n * n - 4) || isPerfectSquare(5 * n * n + 4)) == true)
            {
                Console.Write("n is fabonacci");
            }
            else
            {
                Console.Write("n is not fabonacci");
            }
        }
        public static void testIsFabonacci()
        {
            Console.Write("enter the number");
            int n = int.Parse(Console.ReadLine());
            checkNISFabonacci(n);
        }
    }
}
