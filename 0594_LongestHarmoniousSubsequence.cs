using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _0594_LongestHarmoniousSubsequence
    {
        public void Run()
        {
            int[] nums = [1, 3, 2, 2, 5, 2, 3, 7]; // 5
            //int[] nums = [1, 2, 3, 4]; // 2

            var y = FindLHS(nums);

            Console.WriteLine(y);
        }

        public int FindLHS(int[] nums)
        {

        }

    }
}
