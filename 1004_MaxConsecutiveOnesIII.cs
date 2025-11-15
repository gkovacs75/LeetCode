using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1004_MaxConsecutiveOnesIII
    {
        public void Run()
        {
            var x1 = LongestOnes([1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0], 2); // 6
            var x2 = LongestOnes([0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1], 3); // 10
            //var x3 = LongestOnes("leetcode", 3); // 2

            Console.WriteLine(x1);
            Console.WriteLine(x2);
            //Console.WriteLine(x3);
        }

        public int LongestOnes(int[] nums, int k)
        {
            int p1 = 0;
            int p2 = 0;
            int zeroes = 0;
            int ones = 0;
            int longest = 0;


            while (p2 < nums.Length)
            {
                if (nums[p2] == 0)
                {
                    zeroes++;

                    while (zeroes > k)
                    {
                        if (nums[p1] == 0)
                        {
                            zeroes--;
                        }

                        p1++;
                        ones--;
                    }
                }

                ones++;

                if (ones > longest)
                {
                    longest = ones;
                }

                p2++;
            }

            return longest;
        }
    }
}
