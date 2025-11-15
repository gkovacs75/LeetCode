using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1732_FindTheHighestAltitude
    {
        public void Run()
        {
            var x1 = LargestAltitude([-5, 1, 5, 0, -7]); // 1
            var x2 = LargestAltitude([-4, -3, -2, -1, 4, 3, 2]); // 0
            //var x3 = LargestAltitude([1, 1, 1]); // 2
            //var x4 = LargestAltitude([0, 1, 1, 1, 0, 0, 1, 1, 0]); // 3

            Console.WriteLine(x1);
            Console.WriteLine(x2);
            //Console.WriteLine(x3);
            //Console.WriteLine(x4);
        }

        public int LargestAltitude(int[] gain)
        {
            int y = 0;            
            int highest = y;

            for (int i = 0; i < gain.Length; i++)
            {
                y = y + gain[i];

                if (y > highest)
                {
                    highest = y;
                }
            }

            return highest;
        }
    }
}
