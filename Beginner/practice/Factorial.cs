using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    class Factorial
    {
        public static int fact(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            return n* fact(n - 1) ;
        }

        public static int iterativeFact(int n)
        {
            int prod = 1;
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            for (int i = 2; i <= n; i++)
                prod = prod * i;
                 return prod;
        }
        public static void testfact()
        {
            Console.WriteLine("enter the number ");
            int n = int.Parse(Console.ReadLine());
            int result = fact(n);
            Console.WriteLine(result);
            int iterativeResult = iterativeFact(n);
            Console.WriteLine(iterativeResult);
        }
    }
}
