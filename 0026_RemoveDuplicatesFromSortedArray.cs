using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _0026_RemoveDuplicatesFromSortedArray
    {
        public void Run()
        {
            //int[] nums = [1, 1, 2]; // 2

            int[] nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4]; // 5

            //int[] nums = [1, 2, 3, 1, 2, 3]; // false

            //int[] nums = [1, 2, 3, 1, 2, 3]; // false

            //int[] nums = [0, 1, 2, 3, 2, 5]; // true

            //int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 9]; // true

            var o = RemoveDuplicates(nums);

            Console.WriteLine(o);
        }

        public int RemoveDuplicates(int[] nums)
        {
            int p1 = 0;
            int p2 = 1;

            while (p2 < nums.Length)
            {
                if (nums[p1] != nums[p2])
                {
                    p1++;
                    (nums[p1], nums[p2]) = (nums[p2], nums[p1]);
                }

                p2++;
            }

            return p1 + 1;
        }
    }
}
