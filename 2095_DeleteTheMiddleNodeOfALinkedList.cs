using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2095_DeleteTheMiddleNodeOfALinkedList
    {
        public void Run()
        {
            var n7 = new ListNode(6, null);
            var n6 = new ListNode(2, n7);
            var n5 = new ListNode(1, n6);
            var n4 = new ListNode(7, n5);
            var n3 = new ListNode(4, n4);
            var n2 = new ListNode(3, n3);
            var n1 = new ListNode(1, n2);

            //var n4 = new ListNode(4, null);
            //var n3 = new ListNode(3, n4);
            //var n2 = new ListNode(2, n3);
            //var n1 = new ListNode(1, n2);

            //var n2 = new ListNode(1, null);
            //var n1 = new ListNode(2, n2);

            var x = DeleteMiddle(n1);

            Console.WriteLine("Done");
        }

        public ListNode DeleteMiddle(ListNode head)
        {
            if (head == null) return null;
            ListNode prev = new ListNode(0);
            prev.next = head;
            ListNode slow = prev;
            ListNode fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            slow.next = slow.next.next;
            return prev.next;
        }

        //public ListNode DeleteMiddle2(ListNode head)
        //{
        //    int count = 0;
        //    int index = -1;

        //    var x = DeleteMiddle3(head, count, index);

        //    return x.Item1;
        //}

        //public (ListNode, bool, int) DeleteMiddle3(ListNode node, int count, int index)
        //{
        //    count++;
        //    index++;

        //    if (node.next == null)
        //    {
        //        int indexToDelete = count / 2;

        //        if (index == indexToDelete)
        //        {
        //            return (node.next, true, count);
        //        }

        //        return (null, false, count);
        //    }
        //    else
        //    {
        //        (var x, bool delete, count) = DeleteMiddle2(node.next, count, index);

        //        if (delete)
        //        {
        //            node.next = x;
        //        }

        //        int indexToDelete = count / 2;

        //        if (index == indexToDelete)
        //        {
        //            return (node.next, true, count);
        //        }

        //        if (index == 0)
        //        {
        //            return (node, false, 0); // Original head
        //        }
        //        else
        //        {
        //            return (null, false, count);
        //        }
        //    }
        //}
    }
}
