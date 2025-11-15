using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _0724_FindPivotIndex
    {
        public void Run()
        {
            var x1 = PivotIndex([1, 7, 3, 6, 5, 6]); // 3
            var x2 = PivotIndex([1, 2, 3]); // -1
            var x3 = PivotIndex([2, 1, -1]); // 0
            var x4 = PivotIndex([-1, -1, -1, -1, -1, 0]); // 2

            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(x3);
            Console.WriteLine(x4);
        }

        public int PivotIndex(int[] nums)
        {
            int totalSum = 0;
            int prefixSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                totalSum += nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (prefixSum == totalSum - prefixSum - nums[i])
                {
                    return i;
                }
                else
                {
                    prefixSum += nums[i];
                }

            }

            return -1;
        }
    }
}
