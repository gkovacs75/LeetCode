using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _0169_MajorityElement
    {
        public void Run()
        {
            //int[] nums = [3, 2, 3]; // 3
            int[] nums = [2, 2, 1, 1, 1, 2, 2]; // 2


            var r1 = MajorityElement(nums);

            Console.WriteLine(r1);
        }

        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (var item in nums)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict.Add(item, 1);
                }

            }

            int maxKey= dict.MaxBy(x=>x.Value).Key;

            return maxKey;
        }
    }
}
