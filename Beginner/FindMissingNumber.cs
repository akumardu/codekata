using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    class FindMissingNumber // using Xor method
    {
        public static int missingNumber(List<int> list)
        {
            int size = list.Count;
            int sum_of_numbers = 0;
            int sum_of_list = list[0];
            for (int i = 1; i < size; i++)
                sum_of_list = sum_of_list ^ list[i];
            for (int j = 1; j <= size + 1; j++)
                sum_of_numbers = sum_of_numbers ^ j;
            int number = sum_of_list ^ sum_of_numbers;
            return number;
        }
        public static void testMissingNumber()
        {
            Console.WriteLine("enter the range of numbers");
            int n = int.Parse(Console.ReadLine());
            var list = Enumerable.Range(1,n).ToList();
            list.RemoveAt(3);
            foreach (var i in list)
                Console.WriteLine(i);
            Console.WriteLine("missing number is " + missingNumber(list));

        }
            
    }
       
}
