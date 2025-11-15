using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class _1493LongestSubarrayOf1sAfterDeletingOneElement
    {
        // Given a binary array nums, you should delete one element from it.
        // Return the size of the longest non-empty subarray containing only 1's in the resulting array.
        // Return 0 if there is no such subarray.

        public void Run()
        {
            var x1 = LongestSubarray([1, 1, 0, 1]); // 3
            var x2 = LongestSubarray([0, 1, 1, 1, 0, 1, 1, 0, 1]); // 5
            var x3 = LongestSubarray([1, 1, 1]); // 2
            var x4 = LongestSubarray([0, 1, 1, 1, 0, 0, 1, 1, 0]); // 3

            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(x3);
            Console.WriteLine(x4);
        }
        
        public int LongestSubarray2(int[] nums)
        {
            int p1 = 0;
            int p2 = 0;
            int ones = 0;
            int zeroes = 0;
            int longest = 0;           

            while (p2 < nums.Length)
            {
                if (nums[p2] == 1)
                {
                    ones++;
                    p2++;
                }
                else // 0
                {
                    if (zeroes == 0)
                    {
                        p2++;
                        zeroes++;                        
                    }
                    else
                    {
                        while (zeroes > 0)
                        {
                            if (nums[p1] == 1)
                            {
                                ones--;
                            }
                            p1++;
                            zeroes--;
                        }
                    }
                }

                if (ones > longest)
                {
                    longest = ones;
                }
            }

            if (zeroes == 0)
            {
                longest--;
            }

            return longest;
        }

        public int LongestSubarray(int[] nums)
        {
            int k = 1;
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

            return longest-1;
        }

    }
}
