using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _0872_LeafSimilarTrees
    {
        public void Run()
        {
            // [3,5,1,6,2,9,8,null,null,7,4]            
            TreeNode t1_n9 = new TreeNode(4, null, null);
            TreeNode t1_n8 = new TreeNode(7, null, null);

            TreeNode t1_n7 = new TreeNode(8, null, null);
            TreeNode t1_n6 = new TreeNode(9, null, null);

            TreeNode t1_n5 = new TreeNode(2, t1_n8, t1_n9);
            TreeNode t1_n4 = new TreeNode(6, null, null);

            TreeNode t1_n3 = new TreeNode(1, t1_n6, t1_n7);
            TreeNode t1_n2 = new TreeNode(5, t1_n4, t1_n5);

            TreeNode t1_n1 = new TreeNode(3, t1_n2, t1_n3);

            // [3,5,1,6,7,4,2,null,null,null,null,null,null,9,8]
            TreeNode t2_n9 = new TreeNode(8, null, null);
            TreeNode t2_n8 = new TreeNode(9, null, null);

            TreeNode t2_n7 = new TreeNode(2, t2_n8, t2_n9);
            TreeNode t2_n6 = new TreeNode(4, null, null);

            TreeNode t2_n5 = new TreeNode(7, null, null);
            TreeNode t2_n4 = new TreeNode(6, null, null);

            TreeNode t2_n3 = new TreeNode(1, t2_n6, t2_n7);
            TreeNode t2_n2 = new TreeNode(5, t2_n4, t2_n5);

            TreeNode t2_n1 = new TreeNode(3, t2_n2, t2_n3);

            var x = LeafSimilar(t1_n1, t2_n1); // true

            Console.WriteLine(x);
        }

        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            var leaves1 = new List<int>();
            var leaves2 = new List<int>();

            CollectLeaves(root1, leaves1);
            CollectLeaves(root2, leaves2);

            return leaves1.SequenceEqual(leaves2);
        }

        private void CollectLeaves(TreeNode? node, List<int> leaves)
        {
            if (node == null) return;

            if (node.left == null && node.right == null)
            {
                leaves.Add(node.val);
                return;
            }

            CollectLeaves(node.left, leaves);
            CollectLeaves(node.right, leaves);
        }
    }
}
