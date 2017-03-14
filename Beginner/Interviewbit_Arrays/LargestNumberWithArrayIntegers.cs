using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Interviewbit_Arrays
{
    public class StringComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return (y+x).CompareTo(x+y);
        }
    }
    class LargestNumberWithArrayIntegers
    {
        public static string largestNumber(List<int> inputList)
        {
            string result= "";

            List<string> stringList = new List<string>();
            for(int i = 0; i < inputList.Count; i++)
            {
                stringList.Add(inputList[i].ToString());
            }

            stringList.Sort(new StringComparer());

            for (int i = 0; i < stringList.Count; i++)
            {
                result = result + stringList[i];
            }
            return result;
        }

        public static void testLargestNumber()
        {
            List<int> input = new List<int>();
            input.Add(54);
            input.Add(546);
            input.Add(548);
            input.Add(60);

            string output =largestNumber(input);
            for (int i = 0; i < output.Length; i++)
            {
                Console.Write(output[i]);
            }
        }
        
    }
}
