using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MaxNumberOfKSumPairs
    {
        public void Run()
        {
            var x1 = MaxOperations([1, 2, 3, 4], 5);
            var x2 = MaxOperations([3, 1, 3, 4, 3], 6);
            var x3 = MaxOperations([3], 6);
            var x4 = MaxOperations([1], 1);

            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(x3);
            Console.WriteLine(x4);
        }

        public int MaxOperations(int[] nums, int k)
        {
            int c = 0;
            int i = 0;
            int j = nums.Length - 1;

            Array.Sort(nums);

            while (i < j)
            {
                if (nums[i] + nums[j] == k)
                {
                    c++;
                    i++;
                    j--;
                }
                else if (nums[i] + nums[j] <= k)
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }

            return c;
        }
    }
}
