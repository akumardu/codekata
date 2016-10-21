using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Codewar
{
    class RelativeSpeed
    {
        public static int[] Race(int v1, int v2, int g)
        {
            
            int time_seconds = ((g * 3600) / (v2 - v1));
            int h = time_seconds / (60*60);
            int mn = (time_seconds % (60 * 60)) / 60;
            int s = (time_seconds % (60 * 60)) % 60;
            int []result_arr = new int[] { h, mn, s};
            return result_arr;
        }
        public static void TestRace()
        {
            Console.WriteLine("enter the first speed");
            int v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second speed");
            int v2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the lead");
            int g = int.Parse(Console.ReadLine());
            var arr = Race(v1, v2, g);
            foreach(var r in arr )
            Console.WriteLine(r);
        }
    }
 }
