using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _0328_OddEvenLinkedList
    {
        public void Run()
        {
            var n5 = new ListNode(5, null);
            var n4 = new ListNode(4, n5);
            var n3 = new ListNode(3, n4);
            var n2 = new ListNode(2, n3);
            var n1 = new ListNode(1, n2);

            var x = OddEvenList(n1);

            while (x != null)
            {
                Console.WriteLine(x.val);
                x = x.next;
            }

            Console.WriteLine("Done");
        }

        public ListNode OddEvenList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            var oddList = head;
            var evenList = head.next;
            var ehead = head.next;

            while (evenList != null && evenList.next != null)
            {
                oddList.next = oddList.next.next;
                evenList.next = evenList.next.next;

                oddList = oddList.next;
                evenList = evenList.next;
            }

            oddList.next = ehead;

            return head;
        }
    }
}
