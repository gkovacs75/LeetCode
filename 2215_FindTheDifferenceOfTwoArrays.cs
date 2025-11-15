using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2215_FindTheDifferenceOfTwoArrays
    {
        public void Run()
        {
            // Given two 0-indexed integer arrays nums1 and nums2, return a list answer of size 2 where:
            // 
            // answer[0] is a list of all distinct integers in nums1 which are not present in nums2.
            // answer[1] is a list of all distinct integers in nums2 which are not present in nums1.
            // Note that the integers in the lists may be returned in any order.

            // Constraints:
            // 
            // 1 <= nums1.length, nums2.length <= 1000
            // -1000 <= nums1[i], nums2[i] <= 1000


            var x1 = FindDifference([1, 2, 3], [2, 4, 6]); // [[1,3],[4,6]]
            var x2 = FindDifference([1, 2, 3, 3], [1, 1, 2, 2]); // [[3],[]]


        }

        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            var d1 = new Dictionary<int, int>();
            var d2 = new Dictionary<int, int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                d1.TryAdd(nums1[i], 0);
            }

            for (int i = 0; i < nums2.Length; i++)
            {
                d2.TryAdd(nums2[i], 0);
            }

            foreach (var i in d1)
            {
                if (d2.ContainsKey(i.Key))
                {
                    d1.Remove(i.Key);
                    d2.Remove(i.Key);
                }
            }

            foreach (var i in d2)
            {
                if (d1.ContainsKey(i.Key))
                {
                    d1.Remove(i.Key);
                    d2.Remove(i.Key);
                }
            }

            int[][] a = new int[2][];

            int[] a1 = new int[d1.Count];
            a1 = d1.Keys.ToArray();

            int[] a2 = new int[d2.Count];
            a2 = d2.Keys.ToArray();

            a[0] = a1;
            a[1] = a2;

            return a;
        }
    }
}
