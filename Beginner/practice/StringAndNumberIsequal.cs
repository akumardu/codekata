using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    //http://www.geeksforgeeks.org/check-length-string-equal-number-appended-last/
    class StringAndNumberIsequal
    {
        public static bool IsEqual(string str)
        {
            int n = str.Length;
            int num = 0, x = 1, i = n - 1;
            for (i = n - 1; i >= 0; i--)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    num = (str[i] - '0') * x + num;
                    x = x * 10;
                }
                else break;
            }

            return num == i + 1;
        }
        public static void testISEqual()
        {
            string str = "geeksforgeeks13";
            Console.WriteLine(IsEqual(str));
        }  
    }
}
