using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode
{
    internal class IncreasingTripletSubsequence
    {
        public void Run()
        {
            bool x1 = IncreasingTriplet([1, 2, 3, 4, 5]); // true
            bool x2 = IncreasingTriplet([5, 4, 3, 2, 1]); // false
            bool x3 = IncreasingTriplet([2, 1, 5, 0, 4, 6]); // true
            bool x4 = IncreasingTriplet([20, 100, 10, 12, 5, 13]); // true

            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(x3);
            Console.WriteLine(x4);
        }

        public bool IncreasingTriplet(int[] nums)
        {
            int a = int.MaxValue;
            int b = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= a)
                {
                    a = nums[i];
                }
                else
                {
                    if (nums[i] <= b)
                    {
                        b = nums[i];
                    }
                    else
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
