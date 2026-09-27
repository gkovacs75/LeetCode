using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _0080_RemoveDuplicatesFromSortedArrayII
    {
        public void Run()
        {
            //int[] nums = [1, 1, 1, 2, 2, 3]; // 5
            int[] nums = [0, 0, 1, 1, 1, 1, 2, 3, 3]; // 7


            var r1 = RemoveDuplicates(nums);

            Console.WriteLine(r1);
        }

        public int RemoveDuplicates(int[] nums)
        {
            int p1 = 1;
            int count = 1;

            for (int p2 = 1; p2 < nums.Length; p2++)
            {                
                if (nums[p2] == nums[p2 - 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (count <= 2)
                {
                    nums[p1] = nums[p2];

                    p1++;
                }
            }

            return p1;
        }


    }
}
