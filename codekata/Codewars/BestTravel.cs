using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codekata.Codewars
{
    // https://www.codewars.com/kata/best-travel

    public class BestTravel
    {
        public static int? chooseBestSum(int t, int k, List<int> ls)
        {
            var s = new List<int>(Combinations<int>(ls, k).Select(c => c.Sum()));
            var rv = s.OrderByDescending(i => i).Where(i => i <= t).FirstOrDefault();
            return rv == default(int) ? null : (int?)rv;
        }

        public static IEnumerable<IEnumerable<T>> Combinations<T>(IEnumerable<T> elements, int k)
        {
            return k == 0 ? new[] { new T[0] } :
              elements
                .SelectMany((e, i) => Combinations(elements.Skip(i + 1), k - 1)
                    .Select(c => c.Concat(new[] { e })));
        }
    }
}
