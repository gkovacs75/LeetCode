using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode
{
    internal class _0594_LongestHarmoniousSubsequence
    {
        public void Run()
        {
            Console.WriteLine(FindLHS([1, 3, 2, 2, 5, 2, 3, 7])); // 5
            Console.WriteLine(FindLHS([1, 2, 3, 4])); // 2
            Console.WriteLine(FindLHS([2])); // 1
            Console.WriteLine(FindLHS([1, 1, 1, 1])); // 0
            Console.WriteLine(FindLHS([1, 2, 2, 1])); // 1,1,2,2 -> 4
            Console.WriteLine(FindLHS([1, 1, 1, 1])); // 0
        }
        
        public int FindLHS(int[] nums)
        {
            Array.Sort(nums);

            int p1 = 0;

            int longestSubsetLength = 0;

            for (int p2 = 0; p2 < nums.Length; p2++)
            {
                // Catch up the first pointer
                while (nums[p2] - nums[p1] > 1)
                {
                    p1++;
                }

                if (nums[p2] - nums[p1] == 1)
                {
                    longestSubsetLength = Math.Max(longestSubsetLength, p2 - p1 + 1);
                }
            }

            return longestSubsetLength;
        }

    }
}
