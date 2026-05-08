using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _0027_RemoveElement
    {
        public void Run()
        {

            int[] nums = [3, 2, 2, 3];
            int val = 3; // nums = [2,2,_,_]

            //int[] nums = [0, 1, 2, 2, 3, 0, 4, 2];
            //int val = 2; // nums = [0,1,4,0,3,_,_,_]

            var o = RemoveElement(nums, val);

            Console.WriteLine(o);
        }

        public int RemoveElement(int[] nums, int val)
        {

            int i = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != val)
                {
                    nums[i] = nums[j];
                    i++;
                }
            }

            return i;
        }


        //public int RemoveElement(int[] nums, int val)
        //{
        //    int p2 = 1;

        //    for (int p1 = 0; p1 < nums.Length; p1++)
        //    {
        //        if (p1 == p2)
        //        {
        //            p2++;
        //        }

        //        if (nums[p1] == val)
        //        {
        //            while (p2 < nums.Length)
        //            {
        //                if (nums[p2] != val)
        //                {
        //                    (nums[p1], nums[p2]) = (nums[p2], nums[p1]);
        //                    break;
        //                }
        //                else
        //                {
        //                    p2++;
        //                }
        //            }
        //        }                
        //    }

        //    var c = nums.Where(x => x != val).Count();

        //    return c;
        //}
    }
}
