using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codekata.Codewars
{
    // https://www.codewars.com/kata/integers-recreation-one/csharp
    public class RecreationOne
    {
        public static string listSquared(long m, long n)
        {
            var result = new List<Tuple<long, long>>();
            for(long i = m; i <= n; i++)
            {
                var squared = FindSumOfSquaredFactors(i);
                if(IsSquare(squared))
                {
                    result.Add(new Tuple<long, long>(i, squared));
                }
            }

            if (result.Count == 0)
                return "[]";
            return ConvertToString(result);
        }

        private static string ConvertToString(List<Tuple<long, long>> coll)
        {
            var builder = new StringBuilder();
            builder.Append("[");
            foreach(var result in coll)
            {
                builder.Append("[" + result.Item1 + ", " + result.Item2 + "], ");
            }
            builder.Remove(builder.Length - 2, 2);
            builder.Append("]");
            return builder.ToString();
        }

        public static bool IsSquare(long num)
        {
            return Math.Sqrt(num) % 1 == 0;
        }

        public static long FindSumOfSquaredFactors(long num)
        {
            long sum = 0;
            long i = 1;
            for(i = 1; i <= (num/2+1); i++)
            {
                if((num %i) == 0)
                {
                    sum += (i*i);
                }
            }

            if (i <= num)
                sum += (num * num);
            return sum;
        }
    }
}
