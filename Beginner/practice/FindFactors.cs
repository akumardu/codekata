using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    class FindFactors
    {
        public static List<int> factor(int n)
        {
            List<int> factors = new List<int>();
            for (int i = 1; i <= Math.Sqrt(n); i++)
            {
                if ((n % i) == 0)
                {
                    factors.Add(i);
                    if(i != n/i)
                    factors.Add(n / i);
                }
            }
            return factors;
        }
        public static List<int> primeNumberUptoN(int n)
        {
            List<int> primeNumbers = new List<int>();
            bool[] primeArr = new bool[n + 1];
            for (int i = 0; i < primeArr.Length; i++)
            {
                primeArr[i] = true;
            }
            for (int i = 2; i < primeArr.Length; i++)
            {
                for (int j = 2; i*j < primeArr.Length; j++)
                {
                    primeArr[i * j] = false;
                }
            }
            for (int i = 1; i < primeArr.Length; i++)
            {
                if (primeArr[i] == true)
                    primeNumbers.Add(i);
            }
            return primeNumbers;

        }
        public static List<int> primeFactors(int n)
        {
            List<int> factors = new List<int>();
            List<int> temp= primeNumberUptoN(n);
            for (int i = 0; i < temp.Count; i++)
            {
                if (n % temp[i] == 0)
                {
                    factors.Add(temp[i]);
                }
            }
            return factors;
        }
        public static void testFactor()
        {
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            List<int> result = factor(n);
            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.WriteLine();

            List<int> primeResult = primeNumberUptoN(n);
            Console.WriteLine($"Prime numbers upto {n} are");
            for (int i = 0; i < primeResult.Count; i++)
            {
                Console.WriteLine( primeResult[i]);
            }
            List<int> primeResult2 = primeFactors(n);
            Console.WriteLine($"Prime factors of {n} are");
            for (int i = 0; i < primeResult2.Count; i++)
            {
                Console.WriteLine(primeResult2[i]);
            }
        }
    }
}
