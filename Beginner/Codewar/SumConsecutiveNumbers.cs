using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Codewar
{
    class SumConsecutiveNumbers
    {
        public static List<int> SumConsecutives(List <int>s)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < s.Count(); i++)
            {
                int sum = s[i];
                while((i + 1) < s.Count && s[i]==s[i+1])
                {
                    sum = sum + s[i + 1];
                    i++;
                }
                result.Add(sum);
            }

            return result;
        }
        public static void TestSumConsecutives()
        {
            Console.WriteLine("enter the list");
            List<int> List = new List<int>();
            while (true)
            {
                int temp = int.Parse(Console.ReadLine());
                if (temp == 0)
                    break;
                List.Add(temp);
            }
            Console.WriteLine("result is");

            var result = SumConsecutives(List);
            foreach (var r in result)
                Console.WriteLine(r);
        }

    }
}
