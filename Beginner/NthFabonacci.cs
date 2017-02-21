using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    //http://www.practice.geeksforgeeks.org/problem-page.php?pid=294
    class NthFabonacci
    {
        //Method 1: using 2 variables and b
       
        public static int fabonacciAtNth(int n)
        {
            int a = 0, b = 1, c, sum=0;
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            for(int i=2; i<=n; i++)
            {
                c = a + b;
                // sum will give the sum of fabonacci numbers upto n
                sum = sum + c;
                a = b;
                b = c;
            }
            Console.WriteLine("sum is " + sum);
            return b % 1000000007;
        }
        
        
         // Method 2: using Recurison
         public static int fib(int n)
         {
             if (n == 0)
                 return 0;
             if(n == 1)
                 return 1;
              return fib(n-1)+fib(n-2);
         }
         
        //Method 3: Dynamic Programming
        public static int fibDynamic(int n)
        {
            int[] arr = new int[n + 1];
            arr[0] = 0;
            arr[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }
            return arr[n];
        }
        
        public static void testFabonacciAtNth()
        {
            int result = fabonacciAtNth(9);
            int result2 = fib(9);
            int result3 = fibDynamic(9);
            Console.WriteLine("Iterative " + result);
            Console.WriteLine("recursive " + result2);
            Console.WriteLine("dynamic " + result3);

        }

    }
}
