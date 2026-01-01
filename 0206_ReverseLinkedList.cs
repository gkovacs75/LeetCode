using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _0206_ReverseLinkedList
    {
        public void Run()
        {
            //var head = [1, 2, 3, 4, 5]; // -> [5,4,3,2,1]

            var n5 = new ListNode(5, null);
            var n4 = new ListNode(4, n5);
            var n3 = new ListNode(3, n4);
            var n2 = new ListNode(2, n3);
            var n1 = new ListNode(1, n2);


            //var n0 = new ListNode();

            var x = ReverseList(null);
            Console.WriteLine("Done");
        }

        public ListNode ReverseList(ListNode node)
        {
            if (node != null)
            {
                return ReverseList2(node);
            }
            return null;
        }

        public ListNode ReverseList2(ListNode node, ListNode? parentNode = null)
        {
            if (node.next == null)
            {
                node.next = parentNode;

                return node;
            }
            else
            {
                var innerMostNode = ReverseList2(node.next, node);

                node.next = parentNode;

                return innerMostNode;
            }
        }
    }
}
