using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _0219_ContainsDuplicate2
    {
        public void Run()
        {
            //int[] nums = [1, 2, 3, 1]; // true
            //int k = 3;

            //int[] nums = [1, 0, 1, 1]; // true
            //int k = 1;

            //int[] nums = [1, 2, 3, 1, 2, 3]; // false
            //int k = 2;

            //int[] nums = [1, 2, 3, 1, 2, 3]; // false
            //int k = 2;

            //int[] nums = [0, 1, 2, 3, 2, 5]; // true
            //int k = 3;

            int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 9]; // true
            int k = 3;

            var o = ContainsNearbyDuplicate(nums, k);

            Console.WriteLine(o);
        }

        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> set = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (set.ContainsKey(nums[i]))
                {
                    set.TryGetValue(nums[i], out int stored_i);

                    if (i - stored_i <= k)
                    {
                        return true;
                    }
                    else
                    {
                        set.Remove(nums[i]);
                        set.Add(nums[i], i);
                    }
                }
                else
                {
                    set.Add(nums[i], i);
                }
            }

            return false;
        }
    }
}
