using System;
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
            int[] nums = [-1, 0, 1, 2, -1, -4]; // [[-1,-1,2],[-1,0,1]]

            // nums = [0,1,1] -> []
            // nums = [0,0,0] -> [[0,0,0]]

            var o = ThreeSum(nums);

            Console.WriteLine($"v1:{o[0]}, v2: {o[1]}");
        }

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            return null;
        }
    }
}
