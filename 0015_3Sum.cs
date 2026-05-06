using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _0015_3Sum
    {
        public void Run()
        {
            //int[] nums = [-1, 0, 1, 2, -1, -4]; // [[-1,-1,2],[-1,0,1]]

            //int[] nums = [0, 1, 1]; // -> []
            //int[] nums = [0, 0, 0]; // -> [[0,0,0]]
            int[] nums = [-100, -70, -60, 110, 120, 130, 160]; // [[-100,-60,160],[-70,-60,130]]



            var o = ThreeSum(nums);
        }

        /// <summary>
        /// O n^3
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var output = new List<int[]>();

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        int sum = nums[i] + nums[j] + nums[k];

                        if (sum == 0)
                        {
                            var a = new int[3] { nums[i], nums[j], nums[k] };
                            Array.Sort(a);

                            bool containsSimilarArray = output.Any(arr => arr.SequenceEqual(a));

                            if (!containsSimilarArray)
                            {
                                output.Add(a);
                            }
                        }
                    }
                }
            }

            return output.ToArray();
        }
    }
}
