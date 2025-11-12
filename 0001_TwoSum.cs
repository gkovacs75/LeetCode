using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class TwoSum_
    {
        public void Run()
        {
            var x = TwoSum([2, 7, 11, 15], 9);
        }

        public int[] TwoSum(int[] nums, int target)
        {

            int[] x = new int[2];

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {

                        x[0] = i;
                        x[1] = j;
                        return x;
                    }
                }
            }

            return x;
        }
    }
}
