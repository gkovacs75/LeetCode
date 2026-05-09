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
        // Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]]
        // such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
        // 
        // Notice that the solution set must not contain duplicate triplets.
        // 
        //  
        // 
        // Example 1:
        // 
        // Input: nums = [-1,0,1,2,-1,-4]
        // Output: [[-1,-1,2],[-1,0,1]]
        // Explanation: 
        // nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
        // nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
        // nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
        // The distinct triplets are [-1,0,1] and [-1,-1,2].
        // Notice that the order of the output and the order of the triplets does not matter.
        // Example 2:
        // 
        // Input: nums = [0,1,1]
        // Output: []
        // Explanation: The only possible triplet does not sum up to 0.
        // Example 3:
        // 
        // Input: nums = [0,0,0]
        // Output: [[0,0,0]]
        // Explanation: The only possible triplet sums up to 0.
        //  
        // 
        // Constraints:
        // 
        // 3 <= nums.length <= 3000
        // -105 <= nums[i] <= 105
        //  



        public void Run()
        {
            //int[] nums = [-1, 0, 1, 2, -1, -4]; // [[-1,-1,2],[-1,0,1]]
            //int[] nums = [0, 1, 1]; // -> []
            //int[] nums = [0, 0, 0]; // -> [[0,0,0]]
            //int[] nums = [-100, -70, -60, 110, 120, 130, 160]; // [[-100,-60,160],[-70,-60,130]]
            int[] nums = [-2, 0, 1, 1, 2]; // [[-2,0,2],[-2,1,1]]


            var o = ThreeSum(nums);
        }

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);

            var output = new List<int[]>();

            for (int i = 0; i < nums.Length - 1; i++)
            {
                int j = i + 1;
                int k = nums.Length - 1;

                while (j < k)
                {
                    int sum = nums[i] + nums[j] + nums[k];

                    if (sum < 0)
                    {
                        j++;
                    }
                    else if (sum > 0)
                    {
                        k--;
                    }
                    else
                    {
                        var a = new int[3] { nums[i], nums[j], nums[k] };

                        bool containsSimilarArray = output.Any(arr => arr.SequenceEqual(a));

                        if (!containsSimilarArray)
                        {
                            output.Add(a);
                        }

                        j++;
                        k--;                        
                    }
                }                
            }

            return output.ToArray();
        }

        /// <summary>
        /// O n^3
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<IList<int>> ThreeSumV1(int[] nums)
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
