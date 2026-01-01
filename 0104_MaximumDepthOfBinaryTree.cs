using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _0104_MaximumDepthOfBinaryTree
    {
        public void Run()
        {
            // [3,9,20,null,null,15,7]
            //TreeNode l1 = new TreeNode(9, null, null);
            //TreeNode r3 = new TreeNode(15, null, null);
            //TreeNode r4 = new TreeNode(7, null, null);
            //TreeNode r1 = new TreeNode(20, r3, r4);
            //TreeNode r = new TreeNode(3, l1, r1); // 3

            // [1, null, 2]
            TreeNode r1 = new TreeNode(2, null, null);
            TreeNode r = new TreeNode(1, null, r1); // 2

            var x = MaxDepth(r);

            Console.WriteLine(x);
        }

        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                var count = 1;
                
                var leftCount = MaxDepth(root.left);
                var rightCount = MaxDepth(root.right);

                return count + Math.Max(leftCount, rightCount);
            }
        }
    }
}
