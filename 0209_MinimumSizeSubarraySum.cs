using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _0209_MinimumSizeSubarraySum
    {
        // Given an array of positive integers nums and a positive integer target,
        // return the minimal length of a subarray whose sum is greater than or equal to target.
        // If there is no such subarray, return 0 instead.
        // 
        //  
        // 
        // Example 1:
        // 
        // Input: target = 7, nums = [2,3,1,2,4,3]
        // Output: 2
        // Explanation: The subarray [4,3] has the minimal length under the problem constraint.
        // Example 2:
        // 
        // Input: target = 4, nums = [1,4,4]
        // Output: 1
        // Example 3:
        // 
        // Input: target = 11, nums = [1,1,1,1,1,1,1,1]
        // Output: 0
        //  
        // 
        // Constraints:
        // 
        // 1 <= target <= 109
        // 1 <= nums.length <= 105
        // 1 <= nums[i] <= 104
        //  
        // 
        // Follow up: If you have figured out the O(n) solution, try coding another solution of which the time complexity is O(n log(n)).
        //  

        public void Run()
        {
            int[] nums = [2, 3, 1, 2, 4, 3];
            int target = 7;

            var y = MinSubArrayLen(target, nums);

            Console.WriteLine(y);
        }

        public int MinSubArrayLen(int target, int[] nums)
        {
            int currentAcceptableDistance = 0;
            int shortestDistance = 0;
            int i = 0;
            int j = 1;
            int sum;
            bool found = false;

            if (nums[i] == target)
            {
                return 1;
            }

            sum = nums[i] + nums[j];

            while (i < nums.Length && j < nums.Length)
            {
                if (sum >= target)
                {
                    currentAcceptableDistance = j - i + 1;
                    sum -= nums[++i];
                }
                else if (sum < target)
                {
                    sum += nums[++j];
                }

                if (currentAcceptableDistance < shortestDistance)
                {
                    found = true;
                    shortestDistance = currentAcceptableDistance;
                }
            }

            if (found)
            {
                return shortestDistance;
            }
            else
            {
                return 0;
            }
        }
    }
}
