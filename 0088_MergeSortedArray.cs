using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _0088_MergeSortedArray
    {
        public void Run()
        {
            int[] nums1 = [1, 2, 3, 0, 0, 0]; // [1,2,2,3,5,6]
            int m = 3;
            int[] nums2 = [2, 5, 6];
            int n = 3;

            Merge(nums1, m, nums2, n);

        }
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int j = 0, i = m; j < n; j++, i++)
            {
                nums1[i] = nums2[j];
            }

            Array.Sort(nums1);
        }
    }
}
