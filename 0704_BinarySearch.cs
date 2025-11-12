using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode
{
    internal class BinarySearch
    {
        public void Run()
        {
            int[] nums = [-1, 0, 3, 5, 9, 12];

            var r1 = Search(nums, 2);

            Console.WriteLine(r1);
        }

        public int Search(int[] nums, int target)
        {
            int bottom = 0;
            int top = nums.Length - 1;
            int mid = top / 2;

            while (bottom <= top)
            {
                if (target == nums[mid])
                {
                    return mid;
                }
                else if (target < nums[mid])
                {
                    top = mid - 1;
                }
                else if (target > nums[mid])
                {
                    bottom = mid + 1;                    
                }

                mid = (bottom + top) / 2;
            }

            return -1;
        }

        public int Search2(int[] nums, int target)
        {
            int low = 0, high = nums.Length - 1, mid = (low + high) / 2;

            while (low <= high)
            {
                if (nums[mid] == target) return mid;
                if (nums[mid] > target) high = mid - 1;
                if (nums[mid] < target) low = mid + 1;
                mid = (low + high) / 2;
            }
            return -1;
        }
    }
}
