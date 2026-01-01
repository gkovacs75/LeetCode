using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class _2130_MaximumTwinSumOfALinkedList
    {
        public void Run()
        {
            //var n4 = new ListNode(4, null);
            //var n3 = new ListNode(3, n4);
            //var n2 = new ListNode(2, n3);
            //var n1 = new ListNode(1, n2);

            var n4 = new ListNode(1, null);
            var n3 = new ListNode(2, n4);
            var n2 = new ListNode(4, n3);
            var n1 = new ListNode(5, n2);

            //var n4 = new ListNode(3, null);
            //var n3 = new ListNode(2, n4);
            //var n2 = new ListNode(2, n3);
            //var n1 = new ListNode(4, n2);

            //var n2 = new ListNode(100000, null);
            //var n1 = new ListNode(1, n2);

            var x = PairSum(n1);

            Console.WriteLine(x);
        }

        public int PairSum(ListNode head)
        {
            int maxTwinSum = -1;
            int n = 2;

            ListNode slow = head;
            ListNode fast = head.next.next;
            while (fast != null && fast.next != null)
            {
                n += 2;
                slow = slow.next;
                fast = fast.next.next;
            }

            ListNode secondHalf = slow.next;

            ListNode reversedSecondHalf = ReverseList2(secondHalf);

            int i = 0;

            ListNode p2 = head;
            while (p2 != null && i < n / 2)
            {
                int twinSum = 0;

                ListNode p3 = head;
                
                twinSum = p2.val + reversedSecondHalf.val;

                if (twinSum > maxTwinSum)
                {
                    maxTwinSum = twinSum;
                }

                i++;
                p2 = p2.next;
                reversedSecondHalf = reversedSecondHalf.next;
            }

            return maxTwinSum;
        }
        
        private ListNode ReverseList2(ListNode node, ListNode? parentNode = null)
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
